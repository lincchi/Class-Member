using System;

namespace LatihanMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //deklarasi variabel hasil
            int hasil;

            //membuat objek dari class calculator
            Calculator cal = new Calculator();

            //memanggil method
            hasil = cal.Penjumlahan(10, 7);
            CetakHasil("Hasil Penjumlahan : " + hasil);

            hasil = cal.Pengurangan(9, 6);
            CetakHasil("Hasil Pengurangan : " + hasil);

            hasil = Calculator.Perkalian(2, 5);
            CetakHasil("Hasil Perkalian : " + hasil);

            Console.ReadKey();
        }
    
    static void CetakHasil(string hasil)
        {
            Console.WriteLine(hasil);
        }
    }
}
