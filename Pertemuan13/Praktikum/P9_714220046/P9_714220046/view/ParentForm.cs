﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9_714220046.view
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void datamahaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 FormMhs = new Form1();
            FormMhs.MdiParent = this;
            FormMhs.Show();
        }

        private void dataNilaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNilai FrmNilai = new FormNilai();
            FrmNilai.MdiParent = this;
            FrmNilai.Show();
        }

        private void dataMasterBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBarang FormBrg = new FormBarang();
            FormBrg.MdiParent = this;
            FormBrg.Show();
        }

        private void dataTransaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTransaksiBarang FormTrx = new FormTransaksiBarang();
            FormTrx.MdiParent = this;
            FormTrx.Show();
        }

        private void ParentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
