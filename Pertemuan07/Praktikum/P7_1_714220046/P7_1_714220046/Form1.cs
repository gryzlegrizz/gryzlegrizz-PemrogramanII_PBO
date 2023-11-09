using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P7_1_714220046
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(354, 184);
        }

        private void btnCek_Click_1(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                errorMessage += "Nama belum diisi\n";
            }

            if (string.IsNullOrWhiteSpace(txtProdi.Text))
            {
                errorMessage += "Prodi belum diisi\n";
            }
            else if (!Regex.IsMatch(txtProdi.Text, @"^[A-Za-z0-9]+-[A-Za-z0-9]+$"))
            {
                errorMessage += "Prodi harus berformat [Strata]-[Prodi]\n";
            }

            if (string.IsNullOrWhiteSpace(txtKelas.Text))
            {
                errorMessage += "Kelas belum diisi\n";
            }

            if (string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(
                    "Lengkap",
                    "Informasi Data Submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Size = new Size(354, 450);
            }
            else
            {
                MessageBox.Show(
                    errorMessage,
                    "Informasi Data Submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void rbSenin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSenin.Checked)
            {
                cbKuliah.Enabled = true; cbKuliah.Checked = true;
                cbTravel.Enabled = false; cbTravel.Checked = false;
                cbTidur.Enabled = true; cbTidur.Checked = false;
            }
        }

        private void rbMinggu_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMinggu.Checked)
            {
                cbKuliah.Enabled = false; cbKuliah.Checked = false;
                cbTravel.Enabled = true; cbTravel.Checked = true;
                cbTidur.Enabled = true; cbTidur.Checked = false;
            }
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //txtNama.Text = null; 
            //txtProdi.Text = null;
            //txtKelas.Text = null; 

            foreach (Control control in Controls)
            {
                if (control is TextBox)
                    ((TextBox)control).Text = string.Empty;
                else if (control is RadioButton)
                    ((RadioButton)control).Checked = false;
                else if (control is CheckBox)
                    ((CheckBox)control).Checked = false;
                else if (control is ComboBox)
                    ((ComboBox)control).SelectedIndex = -1;
            }

            this.Size = new Size(354, 184);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string hari = "";
            string kegiatan = "";

            if (rbSenin.Checked == true)
            {
                hari = "Senin";
            }
            else if (rbMinggu.Checked == true)
            {
                hari = "Minggu";
            }
            else
            {
                MessageBox.Show("Harus memilih antara hari Senin atau Minggu!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbKuliah.Checked == true)
            {
                kegiatan += "Kuliah, ";
            }
            if (cbTravel.Checked == true)
            {
                kegiatan += "Travelling, ";
            }
            if (cbTidur.Checked == true)
            {
                kegiatan += "Tidur, ";
            }

            kegiatan = kegiatan.TrimEnd(',', ' ');

            if (string.IsNullOrWhiteSpace(kegiatan)) 
            {
                MessageBox.Show("Setidaknya pilih salah satu kegiatan", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Nama: " + txtNama.Text +
                "\nProdi: " + txtProdi.Text +
                "\nKelas: " + txtKelas.Text +
                "\nHari: " + hari +
                "\nKegiatan: " + kegiatan,
                "Informasi List Kegiatan",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
