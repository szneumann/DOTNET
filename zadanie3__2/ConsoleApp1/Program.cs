using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;

public class SymmetricEncryptionBenchmark
{
    public static void Main()
    {
        int dataSizeInBytes = 1024 * 1024; // 1MB

        string[] keySizes = { "128", "256" };

        foreach (string keySize in keySizes)
        {
            Console.WriteLine($"Benchmarking Rijndael Managed with {keySize}-bit key...");

            double memoryEncryptionTime = MeasureMemoryEncryptionTime(keySize, dataSizeInBytes);
            double diskEncryptionTime = MeasureDiskEncryptionTime(keySize, dataSizeInBytes);

            double memoryThroughput = dataSizeInBytes / memoryEncryptionTime;
            double diskThroughput = dataSizeInBytes / diskEncryptionTime;

            Console.WriteLine($"Memory Encryption Time per Block: {memoryEncryptionTime} seconds");
            Console.WriteLine($"Memory Throughput: {memoryThroughput} bytes/second");

            Console.WriteLine($"Disk Encryption Time per Block: {diskEncryptionTime} seconds");
            Console.WriteLine($"Disk Throughput: {diskThroughput} bytes/second");

            Console.WriteLine();
        }
    }

    private static double MeasureMemoryEncryptionTime(string keySize, int dataSize)
    {
        byte[] data = GenerateRandomData(dataSize);
        Stopwatch sw = Stopwatch.StartNew();

        using (RijndaelManaged algorithm = new RijndaelManaged())
        {
            algorithm.KeySize = int.Parse(keySize);
            algorithm.GenerateKey();
            algorithm.GenerateIV();

            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, algorithm.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(data, 0, data.Length);
                }
            }
        }

        sw.Stop();
        return sw.Elapsed.TotalSeconds;
    }

    private static double MeasureDiskEncryptionTime(string keySize, int dataSize)
    {
        string filePath = "encrypted_file.bin";
        byte[] data = GenerateRandomData(dataSize);
        File.WriteAllBytes(filePath, data);

        Stopwatch sw = Stopwatch.StartNew();

        using (RijndaelManaged algorithm = new RijndaelManaged())
        {
            algorithm.KeySize = int.Parse(keySize);
            algorithm.GenerateKey();
            algorithm.GenerateIV();

            using (FileStream fsInput = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (FileStream fsOutput = new FileStream("encrypted_file_out.bin", FileMode.Create, FileAccess.Write))
            using (CryptoStream cs = new CryptoStream(fsOutput, algorithm.CreateEncryptor(), CryptoStreamMode.Write))
            {
                fsInput.CopyTo(cs);
            }
        }

        sw.Stop();
        File.Delete(filePath);
        File.Delete("encrypted_file_out.bin");

        return sw.Elapsed.TotalSeconds;
    }

    private static byte[] GenerateRandomData(int size)
    {
        byte[] data = new byte[size];
        new Random().NextBytes(data);
        return data;
    }
}

