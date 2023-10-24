using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220046
{
    public class ProductMusik
    {
        private string jenisProduk;
        private string judulProduk;
        private string namaArtis;
        private int tahunRilis;
        private decimal durasi;

        public ProductMusik(string jenis, string judul, string artis, int tahun, decimal durasi)
        {
            this.jenisProduk = jenis;
            this.judulProduk = judul;
            this.namaArtis = artis;
            this.tahunRilis = tahun;
            this.durasi = durasi;
        }

        public string JenisProduk { get { return jenisProduk; } set { jenisProduk = value; } }
        public string JudulProduk { get { return judulProduk; } set { judulProduk= value; } }
        public string NamaArtis { get { return namaArtis; } set { namaArtis = value; } }
        public int TahunRilis { get {  return tahunRilis; } set {  tahunRilis = value; } }
        public decimal LamaDurasi { get {  return durasi; } set {  durasi = value; } }


    }
}
 