using System;
using KonyvNevter;

namespace OOPProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Elso valtozat
            Konyv book = new Konyv("Book1", "Writer1", 2020, 500);

            Console.WriteLine($"Book information: {book.MergeInfo()}");
            book.IncreasePrice(10);
            Console.WriteLine($"\nIncrease price by 10%: \n{book.MergeInfo()}\n");

            //Masodik valtozat

            Random rnd = new Random();

            Konyv book2 = new Konyv("Book2", "Writer2", rnd.Next(200, 500));
            Console.WriteLine($"Book information: {book2.MergeInfo()}");

            //Harmadik valtozat

            int konyvekSzama = 5;

            Konyv[] konyvArray = new Konyv[konyvekSzama];

            for (int i = 0; i < konyvekSzama; i++)
            {
                konyvArray[i] = new Konyv("Book" + (i + 1), "Writer" + rnd.Next(1, 5), rnd.Next(2500, 6000), rnd.Next(200, 600));
            }

            Konyv leghosszabbKonyv = konyvArray[0];

            Console.WriteLine("\nKönyvek:\n");

            for (int i = 1; i < konyvekSzama; i++)
            {
                if (konyvArray[i].Oldalszam > leghosszabbKonyv.Oldalszam)
                {
                    leghosszabbKonyv = konyvArray[i];
                }
            }
            foreach (var item in konyvArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nLeghosszab könyv:\n");
            Console.WriteLine(leghosszabbKonyv);
            LeghosszabbParos(konyvArray);
            Szerzok(konyvArray);
            return;

            void LeghosszabbParos(Konyv[] konyvArray)
            {
                int j = 0;
                bool found = false;
                int maxIndex = -1;
                Konyv leghosszabbKonyv;

                while (j < konyvArray.Length && !found)      //Megkeresi a legelső páros konyvet és eltárolja kezőértékként
                {
                    if (konyvArray[j].Paros())
                    {
                        maxIndex = j;
                        found = true;
                    }
                    j++;
                }

                if (found)
                {
                    Konyv leghosszabbParosKonyv = konyvArray[maxIndex];
                    for (; j < konyvArray.Length; j++)           //Csak a legelső páros oldalszámú könyvtől kezd keresni, mert felesleges lenne előről kezdeni
                    {
                        if (konyvArray[j].Oldalszam > leghosszabbParosKonyv.Oldalszam && konyvArray[j].Paros())
                        {
                            leghosszabbKonyv = konyvArray[j];
                        }
                    }
                    Console.WriteLine("\nLeghoszabb páros oldalszámú könyv adatai:\n");
                    Console.WriteLine(leghosszabbParosKonyv + "\n");
                }
                else
                {
                    Console.WriteLine("Nincs páros oldalszámú könyv!");
                }
            }

            void Szerzok(Konyv[] konyvArray)
            {
                string[] szerzok = new string[konyvArray.Length];
                szerzok[0] = konyvArray[0].Writer;

                int szerzodb = 1;
                Console.WriteLine("Szerzőnként: " + konyvArray[0]);
                bool found;

                for (int i = 1; i < konyvArray.Length; i++)
                {
                    found = false;
                    foreach (var item in szerzok)
                    {
                        if (konyvArray[i].Writer == item)
                        {
                            found = true;
                        }
                    }
                    if (!found)
                    {
                        szerzok[szerzodb] = konyvArray[i].Writer;
                        Console.WriteLine("Szerzőnként: " + konyvArray[i]);
                        szerzodb++;
                    }
                }

                Console.WriteLine("\nSzerző db:\n");
                Console.WriteLine(szerzodb);
            }
        }
    }
}