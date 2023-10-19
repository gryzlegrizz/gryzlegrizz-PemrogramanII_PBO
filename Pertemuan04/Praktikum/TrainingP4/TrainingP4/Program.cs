using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingP4
{
    public class Mobil
    {
        public double kecepatan;
        public double bensin;
        public double posisi;
        public string nama;

        public void percepat()
        {
            this.kecepatan += 10;
            this.bensin -= 5;
        }

        public void maju()
        {
            this.posisi += this.kecepatan;
            this.bensin -= 2;
        }

        public void isiBensin(double bensin)
        {
            this.bensin += bensin;
        }

        public Mobil(string nama, double kecepatan, double bensin)
        {
            this.nama = nama;
            this.kecepatan = kecepatan;
            this.bensin = bensin;
            this.posisi = 0;
        }

        public Mobil()
        {
            this.nama = "";
            this.kecepatan = 0;
            this.bensin = 0;
            this.posisi = 0;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Mobil SuatuMobil = new Mobil();
            Mobil MobilSaya = new Mobil() { nama = "Toyota", kecepatan = 0, bensin = 30000, posisi = 0 };
            MobilSaya.maju();
            Console.WriteLine(SuatuMobil.nama);
            Console.WriteLine(SuatuMobil.bensin);

            Console.WriteLine(MobilSaya.nama);
            Console.WriteLine(MobilSaya.bensin);

            Mobil MobilAnda = new Mobil( "Suzuki", 0, 5000);
            Console.WriteLine(MobilAnda.nama);
            Console.WriteLine(MobilAnda.bensin);

            Console.WriteLine("");

            PropertyTest p = new PropertyTest();
            p.Materi = "Bahasa Pemrograman C#";
            Console.WriteLine(p.Materi);

            Person o = new Person();
            o.Nilai = 60;
            Console.WriteLine(o.Nilai);

            Console.WriteLine("");

            Civic r = new Civic();
            Console.WriteLine(r.Roda);
            r.Klakson();
            r.Klakson2();

            Console.WriteLine("");

            Bentuk bulet = new Lingkaran();
            bulet.Gambar();
            //Output "Menggambar Lingkaran..."

            Bentuk kotak = new Persegi();
            kotak.Gambar();
            //Output "Menggambar Persegi..."
        }
    }
}
