using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanMethod
{
    public class Calculator
    {
        public int Penjumlahan(int a, int b)
        {
            return a + b;
        }

        public int Penjumlahan(int a, int b, int c)
        {
            return a + b + c;
        }

        public int Pengurangan(int a, int b)
        {
            return a - b;
        }

        //method static
        public static int Perkalian(int a, int b)
        {
            return a * b;
        }
    }
}
