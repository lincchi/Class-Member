using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanConstructor
{
    class Mahasiswa
    {
        //constructor default
        public Mahasiswa()
        {
        }

        //contructor dengan 2 parameter
        public Mahasiswa(string nim, string nama)
        {
            Nim = nim;
            Nama = nama;
        }

        //properties
        public string Nim { get; set; }
        public string Nama { get; set; }
    }
}
