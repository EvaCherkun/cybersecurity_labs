using System;
using System.IO;
using System.Text;

namespace VernamCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string plaintextFilePath = "C:\\Users\\Єва\\source\\repos\\2 lab 1-2\\2 lab 1-2\\text.txt";
            string encryptedFilePath = "C:\\Users\\Єва\\source\\repos\\2 lab 1-2\\2 lab 1-2\\encfile(6).dat";
            string decryptedFilePath = "C:\\Users\\Єва\\source\\repos\\2 lab 1-2\\2 lab 1-2\\decrypted.txt";

            string key = "Mit21";

            string plaintext = File.ReadAllText(plaintextFilePath, Encoding.UTF8);

            string encryptedText = Encrypt(plaintext, key);
            File.WriteAllText(encryptedFilePath, encryptedText, Encoding.UTF8);

            Console.WriteLine("Текст зашифровано і записано у файл encrypted.dat");

            string decryptedText = Decrypt(encryptedText, key);
            File.WriteAllText(decryptedFilePath, decryptedText, Encoding.UTF8);

            Console.WriteLine("Текст розшифровано і записано у файл decrypted.txt");

           
            Console.WriteLine("Розшифрований текст: ");
            Console.WriteLine(decryptedText);

            Console.ReadLine();
        }

        static string Encrypt(string text, string key)
        {
            StringBuilder encryptedText = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                char encryptedChar = (char)(text[i] ^ key[i % key.Length]);
                encryptedText.Append(encryptedChar);
            }

            return encryptedText.ToString();
        }

        static string Decrypt(string encryptedText, string key)
        {
            return Encrypt(encryptedText, key);
        }
    }
}
