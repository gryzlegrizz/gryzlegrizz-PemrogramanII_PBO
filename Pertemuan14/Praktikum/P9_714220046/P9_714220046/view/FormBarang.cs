using P9_714220046.controller;
using P9_714220046.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace P9_714220046.view
{
    public partial class FormBarang : Form
    {
        Koneksi koneksi = new Koneksi();
        M_barang m_barang = new M_barang();
        string id_barang;


        public void Tampil()
        {
            //Query DB Get MGS
            dataBarang.DataSource = koneksi.ShowData("SELECT * FROM t_barang");

            //Mengubah Nama Kolom Tabel
            dataBarang.Columns[0].HeaderText = "ID";
            dataBarang.Columns[1].HeaderText = "Nama Barang";
            dataBarang.Columns[2].HeaderText = "Harga";
        }

        public FormBarang()
        {
            InitializeComponent();
        }

        public void ResetForm()
        {
            tbNamaBarang.Text = "";
            tbHarga.Text = "";
            tbCariData.Text = "";
        }

        private void FormBarang_Load_1(object sender, EventArgs e)
        {
            Tampil();
        }


        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (tbNamaBarang.Text == "" || (tbNamaBarang.Text).All(Char.IsNumber) || tbHarga.Text == "" || (tbHarga.Text).All(Char.IsLetter))
            {
                MessageBox.Show("Harap masukkan data dengan benar!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Barang brg = new Barang();
                m_barang.NamaBarang = tbNamaBarang.Text;
                m_barang.Harga = tbHarga.Text;

                brg.Insert(m_barang);
                ResetForm();
                Tampil();
            }

        }

        private void dataBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_barang = dataBarang.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbNamaBarang.Text = dataBarang.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbHarga.Text = dataBarang.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if(tbNamaBarang.Text != "" || !tbNamaBarang.Text.All(Char.IsNumber) || tbHarga.Text != "" || !tbHarga.Text.All(Char.IsLetter))
            {
                Barang brg = new Barang();
                m_barang.NamaBarang = tbNamaBarang.Text;
                m_barang.Harga = tbHarga.Text;

                brg.Update(m_barang, id_barang);
                ResetForm();
                Tampil();
            }
            else
            {
                MessageBox.Show("Harap masukkan data dengan benar!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show(
                "Apakah yakin akan menghapus data ini?",
                "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (pesan == DialogResult.Yes)
            {
                controller.Barang brg = new controller.Barang();
                brg.Delete(id_barang);
                ResetForm();
                Tampil();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            //Query DB search data
            dataBarang.DataSource = koneksi.ShowData("SELECT * FROM t_barang WHERE id_barang LIKE '%' '" + tbCariData.Text + "' '%' OR nama_barang LIKE '%' '" + tbCariData.Text + "' '%' OR harga LIKE '%' '" + tbCariData.Text + "' '%' \r\n");
        }

        private string FormatDigitAngka(int number)
        {
            return string.Format("Rp {0:N0}", number);
        }


        private void dataBarang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                if (int.TryParse(e.Value.ToString(), out int number))
                {
                    e.Value = FormatDigitAngka(number);
                    e.FormattingApplied = true;
                }
            }
        }



    }
}

