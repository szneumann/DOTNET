using System.Diagnostics;
using System;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    static void Main()
    {
        // Kopiowanie przy użyciu FileStream

        // Ścieżka do pliku źródłowego
        string sourceFilePath = @"C:\Users\dev\Desktop\tekst.txt";
        // Generowanie pliku o wielkości 300 MB
        GenerateLargeFile(sourceFilePath, 300 * 1024 * 1024); // 300 MB

        // Pomiary czasu kopiowania za pomocą FileStream
        Stopwatch streamStopwatch = new Stopwatch();
        // Ścieżka do docelowego pliku
        string streamDestinationFilePath = @"C:\Users\dev\Desktop\streamDestinationFile.bin";
        streamStopwatch.Start();
        CopyUsingStream(sourceFilePath, streamDestinationFilePath);
        streamStopwatch.Stop();
        Console.WriteLine("Czas kopiowania za pomocą FileStream: " + streamStopwatch.Elapsed);

        // Pomiary czasu kopiowania za pomocą metody File.Copy
        Stopwatch fileCopyStopwatch = new Stopwatch();
        string fileCopyDestinationFilePath = "fileCopyDestinationFile.bin";
        fileCopyStopwatch.Start();
        CopyUsingFileCopy(sourceFilePath, fileCopyDestinationFilePath);
        fileCopyStopwatch.Stop();
        Console.WriteLine("Czas kopiowania za pomocą metody File.Copy: " + fileCopyStopwatch.Elapsed);

        // Usunięcie wygenerowanych plików
        File.Delete(sourceFilePath);
        File.Delete(streamDestinationFilePath);
        File.Delete(fileCopyDestinationFilePath);

        Console.ReadKey();
    }



    static void GenerateLargeFile(string filePath, long fileSize)
    {
        using (FileStream fs = File.Create(filePath))
        {
            byte[] buffer = new byte[4096];
            Random rand = new Random();
            long bytesWritten = 0;

            while (bytesWritten < fileSize)
            {
                rand.NextBytes(buffer);
                int bytesToWrite = (int)Math.Min(buffer.Length, fileSize - bytesWritten);
                fs.Write(buffer, 0, bytesToWrite);
                bytesWritten += bytesToWrite;
            }
        }
    }

    static void CopyUsingStream(string sourceFilePath, string destinationFilePath)
    {
        try
        {

            using (FileStream sourceStream = File.OpenRead(sourceFilePath))
            using (FileStream destinationStream = File.Create(destinationFilePath))
            {
                sourceStream.CopyTo(destinationStream);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Wystąpił błąd podczas kopiowania pliku: " + ex.Message);
        }
    }
    static void CopyUsingFileCopy(string sourceFilePath, string destinationFilePath)
    {
        try
        {
            File.Copy(sourceFilePath, destinationFilePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Wystąpił błąd podczas kopiowania pliku: " + ex.Message);
        }
    }
}
