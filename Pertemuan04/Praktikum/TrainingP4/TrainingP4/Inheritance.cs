using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingP4
{
    internal class Inheritance
    {
    }

    public class Car
    {
        public int Roda { get; set;}
        public int Tahun { get; set;}

        public void Klakson2()
        {
            Console.WriteLine("TOTOT!!!!!");
        }
    }

    class Civic : Car
    {
        public Civic() 
        {
            Roda = 4;
        }

        public void Klakson()
        {
            Console.WriteLine("TWID TWID TWID TWIIIIIIIIIIID!!!");
        }
    }


}
