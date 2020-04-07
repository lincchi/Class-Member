using System;

namespace LatihanOverloadingMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers number = new Numbers();

            Console.WriteLine("Minimum #1: {0}", number.Minimum(7, 9));
            Console.WriteLine("Minimum #1: {0}", number.Minimum(3, 1, 5));
            Console.WriteLine();
            Console.WriteLine("Maximum #1: {0}", number.Maximum(7, 9));
            Console.WriteLine("Minimum #1: {0}", number.Maximum(3, 1, 5));

            Console.ReadKey();
        }
    }
}
