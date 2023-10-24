using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220046
{
    public class Lagu : ProductMusik
    {
        protected decimal durasi;

        public Lagu(string jenis, string judul, string artis, int tahun, decimal durasi)
            : base(jenis, judul, artis, tahun, durasi)
        {
            this.Durasi = durasi;
        }

        public decimal Durasi
        {
            get
            {
                return this.durasi;
            }
            set
            {
                this.durasi = value;
            }
        }
    }

}
