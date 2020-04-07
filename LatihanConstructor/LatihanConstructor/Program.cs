using System;

namespace LatihanConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat objek mhs1
            Mahasiswa mhs1 = new Mahasiswa();
            CetakHasil(mhs1);

            Console.WriteLine();

            //membuat objek mhs2
            Mahasiswa mhs2 = new Mahasiswa("123", "Yoru");
            CetakHasil(mhs2);
        }


        static void CetakHasil(Mahasiswa mhs)
        {
            Console.WriteLine("Nim : {0}", mhs.Nim);
            Console.WriteLine("Nama : {0}", mhs.Nama);
        }
    }
}
