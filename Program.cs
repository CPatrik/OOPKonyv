using System;

namespace OOPProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Konyv book = new Konyv();

            book.SetTitle("A Book");
            book.SetWriter("The Writer");
            book.SetYear(2020);
            book.SetPrice(5000);

            Console.WriteLine($"Books information: {book.MergeInfo()}");
            book.IncreasePrice(10);
            Console.WriteLine($"Increase price by 10%: {book.MergeInfo()}");
        }
    }
}