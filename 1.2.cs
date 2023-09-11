using System;
using System.Security.Cryptography;

class RNGCryptoServiceProviderDemo
{
    static void Main()
    {
        Console.WriteLine("Generating two cryptographically stable sequences of random numbers");

        // Генеруємо першу криптографічно стійку послідовність
        var rndNumberGenerator1 = new RNGCryptoServiceProvider();
        var randomNumber1 = new byte[64];
        rndNumberGenerator1.GetBytes(randomNumber1);

        // Генеруємо другу криптографічно стійку послідовність
        var rndNumberGenerator2 = new RNGCryptoServiceProvider();
        var randomNumber2 = new byte[64];
        rndNumberGenerator2.GetBytes(randomNumber2);

        Console.WriteLine("Random Sequence 1:");
        Console.WriteLine(Convert.ToBase64String(randomNumber1));

        Console.WriteLine("\nRandom Sequence 2:");
        Console.WriteLine(Convert.ToBase64String(randomNumber2));
    }
}
