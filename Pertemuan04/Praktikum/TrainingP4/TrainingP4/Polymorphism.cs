using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingP4
{
    internal class Polymorphism
    {
    }

    class Bentuk
    {
        public virtual void Gambar()
        {
            Console.Write("Ini adalah Base Class Bentuk");
        }
    }

    class Lingkaran : Bentuk
    {
        public override void Gambar()
        {
            // Menggambar Lingkaran
            Console.WriteLine("Meggambar Lingkaran...");
        }
    }

    class Persegi : Bentuk
    {
        public override void Gambar()
        {
            Console.WriteLine("Menggambar Persegi...");
        }
    }
}
