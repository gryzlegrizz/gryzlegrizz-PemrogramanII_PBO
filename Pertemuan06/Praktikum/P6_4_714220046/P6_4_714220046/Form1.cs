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
using System.Xml.Linq;

namespace P6_4_714220046
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNamaDepan_Leave(object sender, EventArgs e)
        {
            string namaDepan = txtNamaDepan.Text;
            string namaBelakang = txtNamaBelakang.Text;

            if (string.IsNullOrEmpty(namaDepan))
            {
                epWarning.SetError(txtNamaDepan, "Nama tidak boleh kosong!");
                epCorrect.SetError(txtNamaDepan, "");
                epWrong.SetError(txtNamaDepan, "");
            }
            else
            {
                if (!string.IsNullOrEmpty(namaDepan) && (string.IsNullOrEmpty(namaBelakang)))
                {
                    epWarning.SetError(txtNamaDepan, "Nama belakang tidak boleh kosong!");
                    epCorrect.SetError(txtNamaDepan, "");
                    epWrong.SetError(txtNamaDepan, "");

                    epWarning.SetError(txtNamaBelakang, "Nama belakang tidak boleh kosong!");
                    epCorrect.SetError(txtNamaBelakang, "");
                    epWrong.SetError(txtNamaBelakang, "");
                }
                else
                {
                    if ((namaDepan.All(char.IsLetter)) && (namaBelakang.All(char.IsLetter)))
                    {
                        epWarning.SetError(txtNamaDepan, "");
                        epCorrect.SetError(txtNamaDepan, "Nama valid");
                        epWrong.SetError(txtNamaDepan, "");

                        epWarning.SetError(txtNamaBelakang, "");
                        epCorrect.SetError(txtNamaBelakang, "Nama valid");
                        epWrong.SetError(txtNamaBelakang, "");
                    }
                    else
                    {
                        epWarning.SetError(txtNamaDepan, "");
                        epCorrect.SetError(txtNamaDepan, "");
                        epWrong.SetError(txtNamaDepan, "Nama tidak valid");

                        epWarning.SetError(txtNamaBelakang, "");
                        epCorrect.SetError(txtNamaBelakang, "");
                        epWrong.SetError(txtNamaBelakang, "Nama tidak valid");
                    }
                }
            }            
        }

        private void txtNamaBelakang_Leave(object sender, EventArgs e)
        {
            string namaDepan = txtNamaDepan.Text;
            string namaBelakang = txtNamaBelakang.Text;

            if (string.IsNullOrEmpty(namaBelakang))
            {
                epWarning.SetError(txtNamaBelakang, "Nama tidak boleh kosong!");
                epCorrect.SetError(txtNamaBelakang, "");
                epWrong.SetError(txtNamaBelakang, "");
            }
            else
            {
                if (string.IsNullOrEmpty(namaDepan) && (!string.IsNullOrEmpty(namaBelakang)))
                {
                    epWarning.SetError(txtNamaBelakang, "Nama depan tidak boleh kosong!");
                    epCorrect.SetError(txtNamaBelakang, "");
                    epWrong.SetError(txtNamaBelakang, "");

                    epWarning.SetError(txtNamaDepan, "Nama depan tidak boleh kosong!");
                    epCorrect.SetError(txtNamaDepan, "");
                    epWrong.SetError(txtNamaDepan, "");
                }
                else
                {
                    if ((namaDepan.All(char.IsLetter)) && (namaBelakang.All(char.IsLetter)))
                    {
                        epWarning.SetError(txtNamaDepan, "");
                        epCorrect.SetError(txtNamaDepan, "Nama valid");
                        epWrong.SetError(txtNamaDepan, "");

                        epWarning.SetError(txtNamaBelakang, "");
                        epCorrect.SetError(txtNamaBelakang, "Nama valid");
                        epWrong.SetError(txtNamaBelakang, "");
                    }
                    else
                    {
                        epWarning.SetError(txtNamaDepan, "");
                        epCorrect.SetError(txtNamaDepan, "");
                        epWrong.SetError(txtNamaDepan, "Nama tidak valid");

                        epWarning.SetError(txtNamaBelakang, "");
                        epCorrect.SetError(txtNamaBelakang, "");
                        epWrong.SetError(txtNamaBelakang, "Nama tidak valid");
                    }
                }
            }
        }

        private void txtNoTelp_Leave(object sender, EventArgs e)
        {
            string noTelp = txtNoTelp.Text;

            if (noTelp.Length >= 14 || noTelp.Length <= 11)
            {
                epWarning.SetError(txtNoTelp, "Nomor Telepon setidaknya sebanyak \n11 karakter dan tidak lebih dari 14 karakter");
                epWrong.SetError(txtNoTelp, "");
                epCorrect.SetError(txtNoTelp, "");
            }
            else if (noTelp.StartsWith("08") && noTelp.Substring(2).All(Char.IsNumber))
            {
                epWarning.SetError(txtNoTelp, "");
                epWrong.SetError(txtNoTelp, "");
                epCorrect.SetError(txtNoTelp, "Nomor Telepon valid!");
            }
            else
            {
                epWrong.SetError(txtNoTelp, "Inputan hanya berisi angka dan diawali dengan '08'!");
                epWarning.SetError(txtNoTelp, "");
                epCorrect.SetError(txtNoTelp, "");
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            if (Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^\s]+(\.[^@\s]+)+$"))
            {
                epWarning.SetError(txtEmail, "");
                epWrong.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "Email Valid!");
            }
            else
            {
                epWrong.SetError(txtEmail, "Format email salah!\nContoh: email@example.com");
                epWarning.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "");
            }
        }

        /*private bool IsValidPhoneNumber(string phoneNumber)
        {
            return phoneNumber.StartsWith("08") && phoneNumber.Length >= 14 && IsInteger(phoneNumber);
        }*/

        private bool IsString(string value)
        {
            return !string.IsNullOrWhiteSpace(value) && value.All(char.IsLetter);
        }

        private bool IsInteger(string value)
        {
            return int.TryParse(value, out _);
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$";
            return Regex.IsMatch(email, pattern);
        }

        private void btnPesan_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNamaDepan.Text) || !IsString(txtNamaDepan.Text))
            {
                MessageBox.Show("Nama Depan harus diisi dengan teks!",
                    "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNamaBelakang.Text) || !IsString(txtNamaBelakang.Text))
            {
                MessageBox.Show("Nama Belakang harus diisi dengan teks!",
                    "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNoTelp.Text))
            {
                MessageBox.Show("No Telepon harus diisi dengan angka yang diawali dengan '08' dan memiliki panjang antara 11 hingga 14 karakter!",
                    "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Email tidak sesuai format!",
                    "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string lapangan = "";
            string durasi = "";

            if (rbLap1.Checked == true)
            {
                lapangan = "Lapangan 1";
            }
            else if (rbLap2.Checked == true)
            {
                lapangan = "Lapangan 2";
            }
            else if (rbLap3.Checked == true)
            {
                lapangan = "Lapangan 3";
            }
            else
            {
                MessageBox.Show("Harus memilih salah satu lapangan!",
                    "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rb45menit.Checked == true)
            {
                durasi = "45 Menit";
            }
            else if (rb60menit.Checked == true)
            {
                durasi = "60 Menit";
            }
            else if (rb90menit.Checked == true)
            {
                durasi = "90 Menit";
            }
            else
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan durasi!",
                    "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string namaDepan = txtNamaDepan.Text.ToUpper();
            string namaBelakang = txtNamaBelakang.Text.ToUpper();
            string email = txtEmail.Text.ToLower();

            MessageBox.Show("Nama Pemesan: " + namaDepan + " " + namaBelakang +
               "\nNo Telp: " + txtNoTelp.Text +
               "\nEmail: " + email +
               "\n\nPilihan Lapangan: " + lapangan +
               "\nDurasi Pesanan: " + durasi +
               "\nTanggal Pesanan: " + tglPesanan.Text +
               "\nWaktu Pesanan: " + jamPesanan.Text,
               "Informasi Pendaftaran",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
