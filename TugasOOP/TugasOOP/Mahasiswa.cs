using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasOOP
{
    class Mahasiswa
    {
        //ENKAPSULASI NIM, MANA, MATAKULIAH
        public string Nim { get; set; }
        public string Nama { get; set; }
        public List<MataKuliah> MataKuliahs { get; set; }

        public Mahasiswa(string nim, string nama)
        {
            Nim = nim;
            Nama = nama;
            MataKuliahs = new List<MataKuliah>();

        }
        public void TampilMataKuliah()
        {
            int angka = 0;
            Console.WriteLine("--======== Daftar Mata Kuliah ========--");
            foreach (MataKuliah mk in MataKuliahs)
            {
                Console.WriteLine($"Mata Kuliah ke-{angka+=1}: {mk.NamaMK}");
            }
        }
    }
}
