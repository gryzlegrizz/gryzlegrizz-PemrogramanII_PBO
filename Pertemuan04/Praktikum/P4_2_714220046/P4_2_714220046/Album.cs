using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220046
{
    public class Album : ProductMusik
    {
        protected decimal _duration;

        public Album(string jenis, string judul, string artis, int tahun, decimal durasi)
            : base(jenis, judul, artis, tahun, durasi)
        {
            this._duration = durasi;

            Console.WriteLine("Album constructor called\n");
        }

        public decimal Durasi
        {
            get
            {
                return _duration;
            }

            set
            {
                _duration = value;
            }
        }
    }

}
