using System;
using System.Collections.Generic;
using System.Text;

namespace OOPProject
{
    internal class Konyv
    {
        private string title;
        private string writer;
        private int year;
        private double price;

        public void IncreasePrice(int percentage)
        {
            price += (double)percentage / 100 * price;
        }

        public string MergeInfo()
        {
            return $"Title: {title} | Writer: {writer} | Publishing year: {year} | Price: {price}";
        }

        public string GetTitle()
        { return title; }

        public void SetTitle(string value)
        { title = value; }

        public string GetWriter()
        { return writer; }

        public void SetWriter(string value)
        { writer = value; }

        public int GetYear()
        { return year; }

        public void SetYear(int value)
        { year = value; }

        public double GetPrice()
        { return price; }

        public void SetPrice(double value)
        { price = value; }
    }
}