using System;

namespace OOPProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Konyv book = new Konyv("A book", "The Writer", 2020, 5000);

            Console.WriteLine($"Books information: {book.MergeInfo()}");
            book.IncreasePrice(10);
            Console.WriteLine($"Increase price by 10%: {book.MergeInfo()}");

            Konyv book2 = new Konyv("2nd book", "2nd Writer");
            Console.WriteLine($"Books information: {book2.MergeInfo()}");
        }
    }
}