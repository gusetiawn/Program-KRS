using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasOOP
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                List<Mahasiswa> mahasiswas = DaftarMahasiswa();
                List<MataKuliah> matkuls = DaftarMataKuliah();
                while (true)
                {
                    Menu();
                    int opsi = Convert.ToInt32(Console.ReadLine());
                    switch (opsi)
                    {
                        case 1:
                            TambahMataKuliah(mahasiswas, matkuls);
                            break;
                        case 2:
                            HapusMataKuliah(mahasiswas);
                            break;
                        case 3:
                            MenampilkanKRSMahasiswa(mahasiswas);
                            break;
                        case 4:
                            TambahMahasiswaBaru(mahasiswas);
                            break;
                        case 5:
                            MenampilkanDaftarMataKuliah(matkuls);
                            break;
                        case 6:
                            MenampilkanKRSMahasiswaTertentu(mahasiswas);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error Bro, " + e.Message);
            }
            finally 
            {
                Console.WriteLine();
                Console.WriteLine("-== PROGRAM BERAKHIR ==-");            
            }

        }
        private static void MenampilkanKRSMahasiswaTertentu(List<Mahasiswa> mahasiswas)
        {

            try
            {
                Console.Write(" >> PILIH MAHASISWA : ");
                int pilihmhs3 = Convert.ToInt32(Console.ReadLine());
                Mahasiswa mahasiswa3 = mahasiswas.ElementAt(pilihmhs3 - 1);
                Console.WriteLine($"Nama : {mahasiswa3.Nama}");
                Console.WriteLine($"NIM : {mahasiswa3.Nim}");
                mahasiswa3.TampilMataKuliah();
                Console.WriteLine("");
            }
            catch (Exception)
            {
                Console.WriteLine("Tidak Ada Mahasiswa Tersebut");
            }
            
        }
        private static void MenampilkanDaftarMataKuliah(List<MataKuliah> matkul)
        {
            Console.WriteLine("-======   MENAMPILKAN MATA KULIAH   ======-");
            Console.WriteLine("--===== DAFTAR MATA KULIAH YANG TERSEDIA =====--");
            Console.WriteLine("--============================================--");
            int angka = 0;
            foreach (MataKuliah mk in matkul)
            {
                Console.WriteLine($"Mata Kuliah ke-{angka += 1}: {mk.NamaMK}");
            }
            Console.WriteLine("");
        }
        private static void TambahMahasiswaBaru(List<Mahasiswa> mahasiswas)
        {
            Console.WriteLine("-===== MASUKKAN MAHASISWA BARU =====-");
            Console.WriteLine("--=================================--");
            Console.Write("Masukkan NIM : ");
            string nim = Console.ReadLine();
            Console.WriteLine("Masukkan Nama : ");
            string nama = Console.ReadLine();
            mahasiswas.Add(new Mahasiswa(nim, nama));
            Console.WriteLine("Mahasiswa Baru Berhasil Ditambahkan");
            Console.WriteLine("");
        }

        private static void MenampilkanKRSMahasiswa(List<Mahasiswa> mahasiswas)
        {
            Console.WriteLine("-=== MATA KULIAH YANG BERHASIL DIAMBIL ===-");
            Console.WriteLine("--=======================================--");
            foreach (Mahasiswa mhs in mahasiswas)
            {
                Console.WriteLine($"NIM  : {mhs.Nim}");
                Console.WriteLine($"NAMA : {mhs.Nama}");
                mhs.TampilMataKuliah();
                Console.WriteLine("");
            }
        }

        private static void HapusMataKuliah(List<Mahasiswa> mahasiswas)
        {
            try
            {
                Console.Write(" >> Pilih Mahasiswa : ");
                int pilihmhs2 = Convert.ToInt32(Console.ReadLine());
                Mahasiswa mahasiswa2 = mahasiswas.ElementAt(pilihmhs2 - 1);
                Console.WriteLine($"Nama Mahasiswa : {mahasiswa2.Nama}");
                Console.WriteLine($"NIM Mahasiswa : {mahasiswa2.Nim}");

                try
                {
                    Console.Write(" >> Pilih Mata Kuliah yang Akan Dihapus: ");
                    int pilihHapus = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"Yakin Anda Akan Menghapus Mata Kuliah {mahasiswa2.MataKuliahs.ElementAt(pilihHapus - 1).NamaMK} ?(y/t)");

                    string ya = Console.ReadLine();
                    switch (ya)
                    {
                        case "y":
                            mahasiswa2.MataKuliahs.RemoveAt(pilihHapus - 1);
                            break;
                        case "t":
                            Console.WriteLine("Baik, Sistem Tidak Akan Menghapus Mata Kuliah Tersebut");
                            break;
                        default:
                            break;
                    }

                    Console.WriteLine("");
                }
                catch (Exception)
                {
                    Console.WriteLine("Maaf, Tidak Ada MataKuliah Tersebut");
                    Console.WriteLine("");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Maaf, Tidak Ada Mahasiswa Tersebut");
                Console.WriteLine("");
            }
        }

        private static void TambahMataKuliah(List<Mahasiswa> mahasiswas, List<MataKuliah> matkuls)
        {

            try
            {
                Console.Write(" >> Pilih Mahasiswa : ");
                int pilihmhs = Convert.ToInt32(Console.ReadLine());
                Mahasiswa mahasiswa = mahasiswas.ElementAt(pilihmhs - 1);
                Console.WriteLine($"Nama Mahasiswa : {mahasiswa.Nama}");
                Console.WriteLine($"NIM Mahasiswa : {mahasiswa.Nim}");

                try
                {
                    Console.Write(" >> Pilih Kode Mata Kuliah Yang Akan Di Tambahkan : ");
                    int pilihMK = Convert.ToInt32(Console.ReadLine());
                    MataKuliah matkuliah = matkuls.ElementAt(pilihMK - 1);
                    mahasiswa.MataKuliahs.Add(matkuliah);
                    Console.WriteLine($"Mata Kuliah {matkuliah.NamaMK} Berhasil Di Tambahkan");
                    Console.WriteLine("");
                }
                catch (Exception)
                {
                    Console.WriteLine("Maaf, Tidak Ada Mata Kuliah Tersebut");
                    Console.WriteLine("");
                }  
            }
            catch (Exception)
            {
                Console.WriteLine("Maaf, Tidak Ada Mahasiswa Tersebut");
                Console.WriteLine("");
            }
            
        }

        private static List<MataKuliah> DaftarMataKuliah()
        {
            List<MataKuliah> matkuls = new List<MataKuliah>();
            matkuls.Add(new MataKuliah("BAHASA INDONESIA"));
            matkuls.Add(new MataKuliah("BAHASA INGGRIS"));
            matkuls.Add(new MataKuliah("MATEMATIKA"));
            matkuls.Add(new MataKuliah("KALKULUS"));
            matkuls.Add(new MataKuliah("STATISTIKA"));
            matkuls.Add(new MataKuliah("BASIS DATA"));
            matkuls.Add(new MataKuliah("SISTEM DINAMIK"));
            Console.WriteLine("");
            return matkuls;
        }

        private static List<Mahasiswa> DaftarMahasiswa()
        {
            List<Mahasiswa> mahasiswas = new List<Mahasiswa>();
            mahasiswas.Add(new Mahasiswa("1167010001", "Agus Setiawan"));
            mahasiswas.Add(new Mahasiswa("1167010002", "Bernadus Rangga"));
            mahasiswas.Add(new Mahasiswa("1167010003", "Helda Triyanti"));
            mahasiswas.Add(new Mahasiswa("1167010004", "Muhammad Zulfikar"));
            mahasiswas.Add(new Mahasiswa("1167010005", "Mar'ie Muhammad"));
            mahasiswas.Add(new Mahasiswa("1167010006", "Mulia Abror Khairul"));
            Console.WriteLine("");
            return mahasiswas;
        }

        private static void Menu()
        {
            Console.WriteLine("=== SELAMAT DATANG DI PORTAL AKADEMIK ===");
            Console.WriteLine("=== PILIH MENU ===");
            Console.WriteLine("1. Tambah Mata Kuliah");
            Console.WriteLine("2. Hapus Mata Kuliah");
            Console.WriteLine("3. Tampilkan Seluruh KRS Mahasiswa");
            Console.WriteLine("4. Tambah Mahasiswa");
            Console.WriteLine("5. Daftar Mata Kuliah");
            Console.WriteLine("6. Menampilkan KRS Mahasiswa Tertentu");
            Console.WriteLine("=========================================");
            Console.Write(" Menu No. ");
        }
    }
}
