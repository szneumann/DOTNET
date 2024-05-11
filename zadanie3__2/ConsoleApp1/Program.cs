using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;

public class SymmetricEncryptionBenchmark
{
    public static void Main()
    {
        // Rozmiary danych do szyfrowania
        int[] dataSizes = { 1024, 1048576 }; // 1KB, 1MB

        // Algorytmy szyfrowania do przetestowania
        string[] algorithms = { "AES", "Rijndael", "DES", "TripleDES" };

        foreach (string algorithm in algorithms)
        {
            Console.WriteLine($"Benchmarking {algorithm}...");

            foreach (int dataSize in dataSizes)
            {
                Console.WriteLine($"Data Size: {dataSize} bytes");

                // Generowanie losowych danych
                byte[] data = GenerateRandomData(dataSize);

                // Pomiar czasu szyfrowania
                double encryptionTime = MeasureEncryptionTime(algorithm, data);
                Console.WriteLine($"Encryption Time: {encryptionTime} seconds");

                // Pomiar czasu deszyfrowania
                double decryptionTime = MeasureDecryptionTime(algorithm, data);
                Console.WriteLine($"Decryption Time: {decryptionTime} seconds");

                // Obliczenie throughput
                double throughputMemory = dataSize / encryptionTime;
                double throughputDisk = dataSize / decryptionTime;

                Console.WriteLine($"Throughput (Memory): {throughputMemory} bytes/second");
                Console.WriteLine($"Throughput (Disk): {throughputDisk} bytes/second");
            }
        }
    }

    // Metoda do generowania losowych danych
    private static byte[] GenerateRandomData(int size)
    {
        byte[] data = new byte[size];
        new Random().NextBytes(data);
        return data;
    }

    // Metoda do mierzenia czasu szyfrowania
    private static double MeasureEncryptionTime(string algorithmName, byte[] data)
    {
        Stopwatch sw = Stopwatch.StartNew();

        using (SymmetricAlgorithm algorithm = GetAlgorithm(algorithmName))
        {
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

    // Metoda do mierzenia czasu deszyfrowania
    private static double MeasureDecryptionTime(string algorithmName, byte[] data)
    {
        Stopwatch sw = Stopwatch.StartNew();

        using (SymmetricAlgorithm algorithm = GetAlgorithm(algorithmName))
        {
            algorithm.GenerateKey();
            algorithm.GenerateIV();

            using (MemoryStream ms = new MemoryStream(data))
            {
                using (CryptoStream cs = new CryptoStream(ms, algorithm.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    byte[] decryptedData = new byte[data.Length];
                    cs.Read(decryptedData, 0, decryptedData.Length);
                }
            }
        }

        sw.Stop();
        return sw.Elapsed.TotalSeconds;
    }

    // Metoda pomocnicza do uzyskania algorytmu szyfrowania na podstawie nazwy
    private static SymmetricAlgorithm GetAlgorithm(string algorithmName)
    {
        switch (algorithmName)
        {
            case "AES":
                return Aes.Create();
            case "Rijndael":
                return Rijndael.Create();
            case "DES":
                return DES.Create();
            case "TripleDES":
                return TripleDES.Create();
            default:
                throw new ArgumentException("Unknown algorithm");
        }
    }
}

