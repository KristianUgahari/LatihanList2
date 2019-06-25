using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanList2
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat objek mhs1
            Mahasiswa mhs1 = new Mahasiswa();
            mhs1.Nim = "1234";
            mhs1.NamaMahasiswa = "Kristian";

            //membuat objek mhs2
            Mahasiswa mhs2 = new Mahasiswa();
            mhs2.Nim = "5678";
            mhs2.NamaMahasiswa = "Ugahari";

            //membuat objek dosen
            Dosen dosen = new Dosen();
            dosen.Nik = "0002";
            dosen.NamaDosen = "Jhono";

            //membuat objek list
            List<Mahasiswa> list = new List<Mahasiswa>();

            //menambah element list
            //tidak ada proses boxing
            list.Add(mhs1);
            list.Add(mhs2);

            //coba tambahkan objek dosen ke list, apa yang terjadi?
            //list.Add(dosen);

            //mengakses element list
            //tidak ada proses unboxing
            Console.WriteLine("NIM    NAMA");
            Console.WriteLine("===========");
            

            foreach (Mahasiswa mhs in list)
            {
                Console.WriteLine("{0}, {1}", mhs.Nim, mhs.NamaMahasiswa);
            }

            Console.ReadKey();
        }
    }
}
