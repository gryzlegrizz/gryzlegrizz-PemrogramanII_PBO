using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P6_3_714220046
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtHuruf_Leave(object sender, EventArgs e)
        {
            if (txtHuruf.Text == "")
            {
                epWarning.SetError(txtHuruf, "Textbox Huruf tidak boleh kosong!");
                epWrong.SetError(txtHuruf, "");
                epCorrect.SetError(txtHuruf, "");
            }
            else
            {
                if((txtHuruf.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(txtHuruf, "");
                    epWrong.SetError(txtHuruf, "");
                    epCorrect.SetError(txtHuruf, "Betul!");
                }
                else
                {
                    epWrong.SetError(txtHuruf, "Inputan hanya boleh huruf!");
                    epWarning.SetError(txtHuruf, "");
                    epCorrect.SetError(txtHuruf, "");
                }
            }
        }

        private void txtAngka_Leave(object sender, EventArgs e)
        {
            if (txtAngka.Text == "")
            {
                epWarning.SetError(txtAngka, "Textbox Angka tidak boleh kosong!");
                epWrong.SetError(txtAngka, "");
                epCorrect.SetError(txtAngka, "");
            }
            else
            {
                if ((txtAngka.Text).All(Char.IsNumber))
                {
                    epWarning.SetError(txtAngka, "");
                    epWrong.SetError(txtAngka, "");
                    epCorrect.SetError(txtAngka, "Betul!");
                }
                else
                {
                    epWrong.SetError(txtAngka, "Inputan hanya boleh angka!");
                    epWarning.SetError(txtAngka, "");
                    epCorrect.SetError(txtAngka, "");
                }
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^\s]+(\.[^@\s]+)+$"))
            {
                epWarning.SetError(txtEmail, "");
                epWrong.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "Betul!");
            }
            else
            {
                epWrong.SetError(txtEmail, "Format email salah!\nContoh: email@example.com");
                epWarning.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "");
            }
        }

        private void txtAngka1_Leave(object sender, EventArgs e)
        {
            if (IsNumber(txtAngka1.Text) && IsNumber(txtAngka2.Text))
            {
                int angka1 = Convert.ToInt32(txtAngka1.Text);
                int angka2 = Convert.ToInt32(txtAngka2.Text);

                if (angka1 <= angka2)
                {
                    epWarning.SetError(txtAngka1, "Angka1 harus lebih besar dari Angka2");
                    epWrong.SetError(txtAngka1, "");
                    epCorrect.SetError(txtAngka1, "");
                }
                else
                {
                    epWarning.SetError(txtAngka1, "");
                    epWrong.SetError(txtAngka1, "");
                    epCorrect.SetError(txtAngka1, "Betul");
                }
            }
            else
            {
                epWarning.SetError(txtAngka1, "");
                epWrong.SetError(txtAngka1, "Inputan hanya boleh angka!");
                epCorrect.SetError(txtAngka1, "");
            }
        }

        private bool IsNumber(string text)
        {
            int number;
            return int.TryParse(text, out number);
        }

        private void txtAngka2_Leave(object sender, EventArgs e)
        {
            if (IsNumber(txtAngka1.Text) && IsNumber(txtAngka2.Text))
            {
                int angka1 = Convert.ToInt32(txtAngka1.Text);
                int angka2 = Convert.ToInt32(txtAngka2.Text);

                if (angka1 <= angka2)
                {
                    epWarning.SetError(txtAngka2, "Angka1 harus lebih besar dari Angka2");
                    epWrong.SetError(txtAngka2, "");
                    epCorrect.SetError(txtAngka2, "");
                }
                else
                {
                    epWarning.SetError(txtAngka2, "");
                    epWrong.SetError(txtAngka2, "");
                    epCorrect.SetError(txtAngka2, "Betul");
                }
            }
            else
            {
                epWarning.SetError(txtAngka2, "");
                epWrong.SetError(txtAngka2, "Inputan hanya boleh angka!");
                epCorrect.SetError(txtAngka2, "");
            }
        }
    }
}
