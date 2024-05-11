using System;
using System.IO;
using System.Security.Cryptography;

public class RSAFileEncryptor
{
    private static RSA rsa;

    public static void Main(string[] args)
    {
        // Inicjalizacja obiektu RSA
        rsa = RSA.Create();

        // Wygenerowanie kluczy
        RSAParameters publicKey;
        RSAParameters privateKey;
        GenerateKeys(out publicKey, out privateKey);

        // Ścieżki do plików
        // Plik inputFile musi istnieć. 
        // Pliki encryptedFile i decryptedFile jeśli nie istnieją zostaną utworzone pod podaną ścieżką. 
        string inputFile = GetFilePath("który chcesz zaszyfrować");
        string encryptedFile = GetFilePath("zaszyfrowanego");
        string decryptedFile = GetFilePath("odszyfrowanego");

        // Szyfrowanie pliku
        EncryptFile(inputFile, encryptedFile, publicKey);

        // Deszyfrowanie pliku
        DecryptFile(encryptedFile, decryptedFile, privateKey);

        Console.WriteLine("Proces szyfrowania i deszyfrowania zakończony.");
    }

    // Generowanie kluczy RSA
    private static void GenerateKeys(out RSAParameters publicKey, out RSAParameters privateKey)
    {
        publicKey = rsa.ExportParameters(false); // klucz publiczny
        privateKey = rsa.ExportParameters(true); // klucz prywatny
    }

    // Szyfrowanie pliku za pomocą klucza publicznego
    private static void EncryptFile(string inputFile, string outputFile, RSAParameters publicKey)
    {
        try
        {
            byte[] inputBytes = File.ReadAllBytes(inputFile);

            using (RSA rsa = RSA.Create())
            {
                rsa.ImportParameters(publicKey);

                byte[] encryptedBytes = rsa.Encrypt(inputBytes, RSAEncryptionPadding.OaepSHA256);

                File.WriteAllBytes(outputFile, encryptedBytes);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Błąd podczas szyfrowania pliku: " + ex.Message);
        }
    }

    // Deszyfrowanie pliku za pomocą klucza prywatnego
    private static void DecryptFile(string inputFile, string outputFile, RSAParameters privateKey)
    {
        try
        {
            byte[] encryptedBytes = File.ReadAllBytes(inputFile);

            using (RSA rsa = RSA.Create())
            {
                rsa.ImportParameters(privateKey);

                byte[] decryptedBytes = rsa.Decrypt(encryptedBytes, RSAEncryptionPadding.OaepSHA256);

                File.WriteAllBytes(outputFile, decryptedBytes);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Błąd podczas deszyfrowania pliku: " + ex.Message);
        }
    }

    // Metoda pomocnicza do pobierania ścieżki pliku
    private static string GetFilePath(string filepath)
    {
        Console.WriteLine($"Podaj ścieżkę do pliku {filepath}:");
        return Console.ReadLine();
    }
}
