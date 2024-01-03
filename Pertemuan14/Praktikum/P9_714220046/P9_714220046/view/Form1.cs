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

namespace P9_714220046
{
    public partial class Form1 : Form
    {
        Koneksi koneksi = new Koneksi();
        M_mahasiswa m_mhs = new M_mahasiswa();

        public void Tampil()
        {
            //Query DB Get MGS
            dataMahasiswa.DataSource = koneksi.ShowData("SELECT * FROM t_mahasiswa");

            //Mengubah Nama Kolom Tabel
            dataMahasiswa.Columns[0].HeaderText = "NPM";
            dataMahasiswa.Columns[1].HeaderText = "Nama";
            dataMahasiswa.Columns[2].HeaderText = "Angkatan";
            dataMahasiswa.Columns[3].HeaderText = "Alamat";
            dataMahasiswa.Columns[4].HeaderText = "Email";
            dataMahasiswa.Columns[5].HeaderText = "No HP";    
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void ResetForm()
        {
            npm.Text = "";
            nama.Text = "";
            angkatan.SelectedIndex = -1;
            alamat.Text = "";
            email.Text = "";
            nohp.Text = "";
            tbCariData.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Memanggil method Tampil
            Tampil();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (npm.Text == "" || nama.Text == "" || angkatan.SelectedIndex == -1 || alamat.Text == "" || email.Text == "" || nohp.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                controller.Mahasiswa mhs = new controller.Mahasiswa();
                m_mhs.Npm = npm.Text;
                m_mhs.Nama = nama.Text;
                m_mhs.Angkatan = angkatan.Text;
                m_mhs.Alamat = alamat.Text;
                m_mhs.Email = email.Text;
                m_mhs.Nohp = nohp.Text;

                mhs.Insert(m_mhs);

                ResetForm();
                Tampil();

            }
        }

        private void dataMahasiswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            npm.Text = dataMahasiswa.Rows[e.RowIndex].Cells[0].Value.ToString();
            nama.Text = dataMahasiswa.Rows[e.RowIndex].Cells[1].Value.ToString();
            angkatan.Text = dataMahasiswa.Rows[e.RowIndex].Cells[2].Value.ToString();
            alamat.Text = dataMahasiswa.Rows[e.RowIndex].Cells[3].Value.ToString();
            email.Text = dataMahasiswa.Rows[e.RowIndex].Cells[4].Value.ToString();
            nohp.Text = dataMahasiswa.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (npm.Text == "" || nama.Text == "" || angkatan.SelectedIndex == -1 || alamat.Text == "" || email.Text == "" || nohp.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                controller.Mahasiswa mhs = new controller.Mahasiswa();
                m_mhs.Npm = npm.Text;
                m_mhs.Nama = nama.Text;
                m_mhs.Angkatan = angkatan.Text;
                m_mhs.Alamat = alamat.Text;
                m_mhs.Email = email.Text;
                m_mhs.Nohp = nohp.Text;

                string npmMhs = npm.Text;
                mhs.Update(m_mhs, npmMhs);

                ResetForm();
                Tampil();

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show(
                "Apakah yakin akan menghapus data ini?",
                "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (pesan == DialogResult.Yes)
            {
                Mahasiswa mhs = new Mahasiswa();
                mhs.Delete(npm.Text);
                ResetForm();
                Tampil();
            }
        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            //Query DB search data
            dataMahasiswa.DataSource = koneksi.ShowData("SELECT * FROM t_mahasiswa WHERE npm LIKE '%' '" + tbCariData.Text + "' '%' OR nama LIKE '%' '" + tbCariData.Text + "' '%'\r\n");
        }

    }
}
