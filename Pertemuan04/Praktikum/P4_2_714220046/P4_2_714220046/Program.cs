using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220046
{
    class Program
    {
        static void Main(string[] args)
        {
            Lagu produkMusik1 = new Lagu("Lagu", "Rayuan Perempuan Gila", "Nadin Amizah", 2023, 5.10m);
            Album produkMusik2 = new Album("Album", "Untuk Dunia, Cinta, dan Kotornya", "Nadin Amizah", 2023, 51.37m);


            Console.WriteLine("\nProduk Lagu 1 adalah {0} berjudul \"{1}\" dinyanyikan oleh {2}, dirilis pada tahun {3} dengan panjang durasi {4}", produkMusik1.JenisProduk, produkMusik1.JudulProduk, produkMusik1.NamaArtis, produkMusik1.TahunRilis, produkMusik1.LamaDurasi);
            Console.WriteLine("\nProduk Lagu 2 adalah {0} berjudul \"{1}\" dibuat oleh {2}, dirilis pada tahun {3} dengan total durasi {4}\n", produkMusik2.JenisProduk, produkMusik2.JudulProduk, produkMusik2.NamaArtis, produkMusik2.TahunRilis, produkMusik2.LamaDurasi);
        }
    }
}
