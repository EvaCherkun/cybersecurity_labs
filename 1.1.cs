using System;

class Program
{
    static void Main()
    {
        int seed1 = (int)DateTime.Now.Ticks; // властивість у класі DateTime, різне seed-значення для кожного запуску програми,яке визначатиметься за поточним часом.
        int seed2 = seed1 + 1; // Змінюємо seed для другої послідовності


        Random randomGenerator1 = new Random(123);
        Random randomGenerator2 = new Random(seed2);

        Console.WriteLine("Sequence 1:");

        for (int i = 0; i < 15; i++) 
        {
            int randomNumber = randomGenerator1.Next(1, 10); 
            Console.Write(randomNumber + " "); 
        }

        Console.WriteLine("\n\nSequence 2:");

        for (int i = 0; i < 5; i++) 
        {
            int randomNumber = randomGenerator2.Next(1, 10); 
            Console.Write(randomNumber + " "); // Виводимо числа горизонтально
        }

        Console.WriteLine(); 
    }
}
