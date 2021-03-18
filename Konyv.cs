using System;
using System.Collections.Generic;
using System.Text;

namespace KonyvNevter
{
    internal class Konyv
    {
        private string title;
        private string writer;
        readonly private int year;
        private double price;
        private int oldalszam;
        private static string kiado = "Móra";

        public Konyv(string title, string writer, double price, int oldalszam)
        {
            this.title = title;
            this.writer = writer;
            year = DateTime.Now.Year;
            this.price = price;
            this.oldalszam = oldalszam;
        }

        public Konyv(string title, string writer, int oldalszam)
        {
            this.title = title;
            this.writer = writer;
            price = 2500;
            year = DateTime.Now.Year;
            this.oldalszam = oldalszam;
        }

        public void IncreasePrice(int percentage)
        {
            price += (double)percentage / 100 * price;
        }

        public string MergeInfo()
        {
            return $"Title: {title} | Writer: {writer} | Publishing year: {year} | Price: {price} | Pages: {oldalszam} | Publisher: {kiado}";
        }

        public static Konyv LongerBook(Konyv firstBook, Konyv secondBook)
        {
            if (firstBook.oldalszam > secondBook.oldalszam)
            {
                return firstBook;
            }
            else
            {
                return secondBook;
            }
        }

        public bool Paros()
        {
            if (oldalszam % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetTitle()
        { return title; }

        public void SetTitle(string value)
        { title = value; }

        public string GetWriter()
        { return writer; }

        public string Writer
        {
            get { return writer; }
            set { writer = value; }
        }

        public void SetWriter(string value)
        { writer = value; }

        public int GetYear()
        { return year; }

        public double GetPrice()
        { return price; }

        public void SetPrice(double value)
        { price = value; }

        public int Oldalszam
        {
            get { return oldalszam; }
            set { oldalszam = value; }
        }

        public override string ToString()
        {
            return $"Title: {title} | Writer: {writer} | Publishing year: {year} | Price: {price} | Pages: {oldalszam} | Publisher: {kiado}";
        }
    }
}