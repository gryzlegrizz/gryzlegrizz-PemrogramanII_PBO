namespace P5_4_714220046
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Form = new System.Windows.Forms.Label();
            this.label_nama = new System.Windows.Forms.Label();
            this.label_gender = new System.Windows.Forms.Label();
            this.label_tanggalLahir = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.dt_tanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.gb_pilihKelas = new System.Windows.Forms.GroupBox();
            this.gb_pilihJadwal = new System.Windows.Forms.GroupBox();
            this.cb_biola = new System.Windows.Forms.CheckBox();
            this.cb_gitar = new System.Windows.Forms.CheckBox();
            this.cb_sax = new System.Windows.Forms.CheckBox();
            this.cb_kon = new System.Windows.Forms.CheckBox();
            this.cb_piano = new System.Windows.Forms.CheckBox();
            this.cb_drum = new System.Windows.Forms.CheckBox();
            this.cb_vokal = new System.Windows.Forms.CheckBox();
            this.cb_komposer = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.tblTampilkan = new System.Windows.Forms.Button();
            this.tblSelesai = new System.Windows.Forms.Button();
            this.gb_pilihKelas.SuspendLayout();
            this.gb_pilihJadwal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Form
            // 
            this.label_Form.AutoSize = true;
            this.label_Form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(203)))), ((int)(((byte)(179)))));
            this.label_Form.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Form.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Form.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.label_Form.Location = new System.Drawing.Point(327, 28);
            this.label_Form.Name = "label_Form";
            this.label_Form.Padding = new System.Windows.Forms.Padding(5);
            this.label_Form.Size = new System.Drawing.Size(364, 46);
            this.label_Form.TabIndex = 0;
            this.label_Form.Text = "FORM PENDAFTARAN";
            // 
            // label_nama
            // 
            this.label_nama.AutoSize = true;
            this.label_nama.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nama.Location = new System.Drawing.Point(239, 99);
            this.label_nama.Name = "label_nama";
            this.label_nama.Size = new System.Drawing.Size(51, 21);
            this.label_nama.TabIndex = 1;
            this.label_nama.Text = "Nama";
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gender.Location = new System.Drawing.Point(239, 144);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(106, 21);
            this.label_gender.TabIndex = 1;
            this.label_gender.Text = "Jenis Kelamin";
            // 
            // label_tanggalLahir
            // 
            this.label_tanggalLahir.AutoSize = true;
            this.label_tanggalLahir.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tanggalLahir.Location = new System.Drawing.Point(239, 189);
            this.label_tanggalLahir.Name = "label_tanggalLahir";
            this.label_tanggalLahir.Size = new System.Drawing.Size(100, 21);
            this.label_tanggalLahir.TabIndex = 1;
            this.label_tanggalLahir.Text = "Tanggal Lahir";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtName.Location = new System.Drawing.Point(439, 99);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(341, 22);
            this.txtName.TabIndex = 2;
            // 
            // cb_gender
            // 
            this.cb_gender.ForeColor = System.Drawing.Color.Black;
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Items.AddRange(new object[] {
            "Laki-laki",
            "Perempuan"});
            this.cb_gender.Location = new System.Drawing.Point(439, 144);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(341, 24);
            this.cb_gender.TabIndex = 3;
            this.cb_gender.Text = "Pilih Jenis Kelamin";
            // 
            // dt_tanggalLahir
            // 
            this.dt_tanggalLahir.Location = new System.Drawing.Point(439, 189);
            this.dt_tanggalLahir.Name = "dt_tanggalLahir";
            this.dt_tanggalLahir.Size = new System.Drawing.Size(341, 22);
            this.dt_tanggalLahir.TabIndex = 4;
            // 
            // gb_pilihKelas
            // 
            this.gb_pilihKelas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(203)))), ((int)(((byte)(179)))));
            this.gb_pilihKelas.Controls.Add(this.cb_kon);
            this.gb_pilihKelas.Controls.Add(this.cb_sax);
            this.gb_pilihKelas.Controls.Add(this.cb_gitar);
            this.gb_pilihKelas.Controls.Add(this.cb_komposer);
            this.gb_pilihKelas.Controls.Add(this.cb_vokal);
            this.gb_pilihKelas.Controls.Add(this.cb_drum);
            this.gb_pilihKelas.Controls.Add(this.cb_piano);
            this.gb_pilihKelas.Controls.Add(this.cb_biola);
            this.gb_pilihKelas.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_pilihKelas.Location = new System.Drawing.Point(63, 248);
            this.gb_pilihKelas.Name = "gb_pilihKelas";
            this.gb_pilihKelas.Size = new System.Drawing.Size(426, 239);
            this.gb_pilihKelas.TabIndex = 5;
            this.gb_pilihKelas.TabStop = false;
            this.gb_pilihKelas.Text = "Pilih Kelas";
            // 
            // gb_pilihJadwal
            // 
            this.gb_pilihJadwal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(203)))), ((int)(((byte)(179)))));
            this.gb_pilihJadwal.Controls.Add(this.radioButton4);
            this.gb_pilihJadwal.Controls.Add(this.radioButton3);
            this.gb_pilihJadwal.Controls.Add(this.radioButton2);
            this.gb_pilihJadwal.Controls.Add(this.radioButton1);
            this.gb_pilihJadwal.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_pilihJadwal.Location = new System.Drawing.Point(529, 248);
            this.gb_pilihJadwal.Name = "gb_pilihJadwal";
            this.gb_pilihJadwal.Size = new System.Drawing.Size(426, 239);
            this.gb_pilihJadwal.TabIndex = 5;
            this.gb_pilihJadwal.TabStop = false;
            this.gb_pilihJadwal.Text = "Pilih Jadwal";
            // 
            // cb_biola
            // 
            this.cb_biola.AutoSize = true;
            this.cb_biola.Location = new System.Drawing.Point(22, 43);
            this.cb_biola.Name = "cb_biola";
            this.cb_biola.Size = new System.Drawing.Size(67, 25);
            this.cb_biola.TabIndex = 0;
            this.cb_biola.Text = "Biola";
            this.cb_biola.UseVisualStyleBackColor = true;
            // 
            // cb_gitar
            // 
            this.cb_gitar.AutoSize = true;
            this.cb_gitar.Location = new System.Drawing.Point(22, 92);
            this.cb_gitar.Name = "cb_gitar";
            this.cb_gitar.Size = new System.Drawing.Size(67, 25);
            this.cb_gitar.TabIndex = 0;
            this.cb_gitar.Text = "Gitar";
            this.cb_gitar.UseVisualStyleBackColor = true;
            // 
            // cb_sax
            // 
            this.cb_sax.AutoSize = true;
            this.cb_sax.Location = new System.Drawing.Point(22, 141);
            this.cb_sax.Name = "cb_sax";
            this.cb_sax.Size = new System.Drawing.Size(110, 25);
            this.cb_sax.TabIndex = 0;
            this.cb_sax.Text = "Saxophone";
            this.cb_sax.UseVisualStyleBackColor = true;
            // 
            // cb_kon
            // 
            this.cb_kon.AutoSize = true;
            this.cb_kon.Location = new System.Drawing.Point(22, 190);
            this.cb_kon.Name = "cb_kon";
            this.cb_kon.Size = new System.Drawing.Size(106, 25);
            this.cb_kon.TabIndex = 0;
            this.cb_kon.Text = "Konduktor";
            this.cb_kon.UseVisualStyleBackColor = true;
            // 
            // cb_piano
            // 
            this.cb_piano.AutoSize = true;
            this.cb_piano.Location = new System.Drawing.Point(264, 43);
            this.cb_piano.Name = "cb_piano";
            this.cb_piano.Size = new System.Drawing.Size(71, 25);
            this.cb_piano.TabIndex = 0;
            this.cb_piano.Text = "Piano";
            this.cb_piano.UseVisualStyleBackColor = true;
            // 
            // cb_drum
            // 
            this.cb_drum.AutoSize = true;
            this.cb_drum.Location = new System.Drawing.Point(264, 92);
            this.cb_drum.Name = "cb_drum";
            this.cb_drum.Size = new System.Drawing.Size(72, 25);
            this.cb_drum.TabIndex = 0;
            this.cb_drum.Text = "Drum";
            this.cb_drum.UseVisualStyleBackColor = true;
            // 
            // cb_vokal
            // 
            this.cb_vokal.AutoSize = true;
            this.cb_vokal.Location = new System.Drawing.Point(264, 141);
            this.cb_vokal.Name = "cb_vokal";
            this.cb_vokal.Size = new System.Drawing.Size(70, 25);
            this.cb_vokal.TabIndex = 0;
            this.cb_vokal.Text = "Vokal";
            this.cb_vokal.UseVisualStyleBackColor = true;
            // 
            // cb_komposer
            // 
            this.cb_komposer.AutoSize = true;
            this.cb_komposer.Location = new System.Drawing.Point(264, 190);
            this.cb_komposer.Name = "cb_komposer";
            this.cb_komposer.Size = new System.Drawing.Size(104, 25);
            this.cb_komposer.TabIndex = 0;
            this.cb_komposer.Text = "Komposer";
            this.cb_komposer.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(29, 43);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(229, 25);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Senin && Rabu, 14.00 - 16.00";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(29, 91);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(240, 25);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Selasa && Kamis, 14.00 - 16.00";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(29, 140);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(247, 25);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Sabtu && Minggu, 09.00 - 11.00";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(29, 189);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(187, 25);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Minggu, 13.00 - 17.00";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // tblTampilkan
            // 
            this.tblTampilkan.Location = new System.Drawing.Point(393, 514);
            this.tblTampilkan.Name = "tblTampilkan";
            this.tblTampilkan.Size = new System.Drawing.Size(96, 32);
            this.tblTampilkan.TabIndex = 6;
            this.tblTampilkan.Text = "&Tampilkan";
            this.tblTampilkan.UseVisualStyleBackColor = true;
            this.tblTampilkan.Click += new System.EventHandler(this.tblTampilkan_Click);
            // 
            // tblSelesai
            // 
            this.tblSelesai.Location = new System.Drawing.Point(529, 514);
            this.tblSelesai.Name = "tblSelesai";
            this.tblSelesai.Size = new System.Drawing.Size(96, 32);
            this.tblSelesai.TabIndex = 6;
            this.tblSelesai.Text = "S&elesai";
            this.tblSelesai.UseVisualStyleBackColor = true;
            this.tblSelesai.Click += new System.EventHandler(this.tblSelesai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(149)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(1019, 577);
            this.Controls.Add(this.tblSelesai);
            this.Controls.Add(this.tblTampilkan);
            this.Controls.Add(this.gb_pilihJadwal);
            this.Controls.Add(this.gb_pilihKelas);
            this.Controls.Add(this.dt_tanggalLahir);
            this.Controls.Add(this.cb_gender);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label_tanggalLahir);
            this.Controls.Add(this.label_gender);
            this.Controls.Add(this.label_nama);
            this.Controls.Add(this.label_Form);
            this.Name = "Form1";
            this.Text = "ASTRA MUSIC SCHOOL";
            this.gb_pilihKelas.ResumeLayout(false);
            this.gb_pilihKelas.PerformLayout();
            this.gb_pilihJadwal.ResumeLayout(false);
            this.gb_pilihJadwal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Form;
        private System.Windows.Forms.Label label_nama;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.Label label_tanggalLahir;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cb_gender;
        private System.Windows.Forms.DateTimePicker dt_tanggalLahir;
        private System.Windows.Forms.GroupBox gb_pilihKelas;
        private System.Windows.Forms.GroupBox gb_pilihJadwal;
        private System.Windows.Forms.CheckBox cb_kon;
        private System.Windows.Forms.CheckBox cb_sax;
        private System.Windows.Forms.CheckBox cb_gitar;
        private System.Windows.Forms.CheckBox cb_vokal;
        private System.Windows.Forms.CheckBox cb_drum;
        private System.Windows.Forms.CheckBox cb_piano;
        private System.Windows.Forms.CheckBox cb_biola;
        private System.Windows.Forms.CheckBox cb_komposer;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button tblTampilkan;
        private System.Windows.Forms.Button tblSelesai;
    }
}

