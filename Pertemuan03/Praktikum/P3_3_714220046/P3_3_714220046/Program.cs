using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_3_714220046
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("MENU PERSEGI PANJANG");
                Console.WriteLine("1. Hitung Luas\n2. Hitung Keliling\n");

                Console.Write("Pilih Menu : ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int pilih))
                {
                    Console.WriteLine(" ");

                    if (pilih == 1)
                    {
                        Console.WriteLine("MENGHITUNG LUAS PERSEGI PANJANG");
                        Console.Write("Masukkan Panjang : ");
                        int panjang = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Masukkan Lebar : ");
                        int lebar = Convert.ToInt32(Console.ReadLine());

                        int hasil = panjang * lebar;
                        Console.WriteLine("Luas Persegi Panjang = " + hasil);
                    }
                    else if (pilih == 2)
                    {
                        Console.WriteLine("MENGHITUNG KELILING PERSEGI PANJANG");
                        Console.Write("Masukkan Panjang : ");
                        int panjang = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Masukkan Lebar : ");
                        int lebar = Convert.ToInt32(Console.ReadLine());

                        int hasil = 2 * (panjang + lebar);
                        Console.WriteLine("Keliling Persegi Panjang = " + hasil);
                    }
                    else
                    {
                        Console.WriteLine("Pilihan tidak valid. Silahkan pilih 1 atau 2!");
                    }
                }
                else
                {
                    Console.WriteLine("Input tidak valid. Silakan masukkan angka.");
                }

                Console.WriteLine("\nIngin Mengulang Kembali? (Y/T)");
            } while (Console.ReadLine().ToUpper() == "Y");
        }
    }
}

