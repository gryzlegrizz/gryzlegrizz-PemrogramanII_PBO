namespace P9_714220046
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
            this.gbTDataMhs = new System.Windows.Forms.GroupBox();
            this.dataMahasiswa = new System.Windows.Forms.DataGridView();
            this.gbFDataMhs = new System.Windows.Forms.GroupBox();
            this.angkatan = new System.Windows.Forms.ComboBox();
            this.nohp = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.alamat = new System.Windows.Forms.TextBox();
            this.nama = new System.Windows.Forms.TextBox();
            this.npm = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbActBtn = new System.Windows.Forms.GroupBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.tbCariData = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbTDataMhs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMahasiswa)).BeginInit();
            this.gbFDataMhs.SuspendLayout();
            this.gbActBtn.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTDataMhs
            // 
            this.gbTDataMhs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbTDataMhs.Controls.Add(this.dataMahasiswa);
            this.gbTDataMhs.Location = new System.Drawing.Point(13, 13);
            this.gbTDataMhs.Name = "gbTDataMhs";
            this.gbTDataMhs.Size = new System.Drawing.Size(981, 287);
            this.gbTDataMhs.TabIndex = 0;
            this.gbTDataMhs.TabStop = false;
            this.gbTDataMhs.Text = "Tabel Data Mahasiswa";
            // 
            // dataMahasiswa
            // 
            this.dataMahasiswa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMahasiswa.Location = new System.Drawing.Point(0, 21);
            this.dataMahasiswa.Name = "dataMahasiswa";
            this.dataMahasiswa.RowHeadersWidth = 51;
            this.dataMahasiswa.RowTemplate.Height = 24;
            this.dataMahasiswa.Size = new System.Drawing.Size(980, 266);
            this.dataMahasiswa.TabIndex = 0;
            this.dataMahasiswa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMahasiswa_CellClick);
            // 
            // gbFDataMhs
            // 
            this.gbFDataMhs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbFDataMhs.Controls.Add(this.angkatan);
            this.gbFDataMhs.Controls.Add(this.nohp);
            this.gbFDataMhs.Controls.Add(this.email);
            this.gbFDataMhs.Controls.Add(this.alamat);
            this.gbFDataMhs.Controls.Add(this.nama);
            this.gbFDataMhs.Controls.Add(this.npm);
            this.gbFDataMhs.Controls.Add(this.label6);
            this.gbFDataMhs.Controls.Add(this.label5);
            this.gbFDataMhs.Controls.Add(this.label4);
            this.gbFDataMhs.Controls.Add(this.label3);
            this.gbFDataMhs.Controls.Add(this.label2);
            this.gbFDataMhs.Controls.Add(this.label1);
            this.gbFDataMhs.Location = new System.Drawing.Point(13, 306);
            this.gbFDataMhs.Name = "gbFDataMhs";
            this.gbFDataMhs.Size = new System.Drawing.Size(605, 326);
            this.gbFDataMhs.TabIndex = 1;
            this.gbFDataMhs.TabStop = false;
            this.gbFDataMhs.Text = "Form Data Mahasiswa";
            // 
            // angkatan
            // 
            this.angkatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.angkatan.FormattingEnabled = true;
            this.angkatan.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.angkatan.Location = new System.Drawing.Point(79, 119);
            this.angkatan.Name = "angkatan";
            this.angkatan.Size = new System.Drawing.Size(467, 24);
            this.angkatan.TabIndex = 5;
            // 
            // nohp
            // 
            this.nohp.Location = new System.Drawing.Point(79, 285);
            this.nohp.Name = "nohp";
            this.nohp.Size = new System.Drawing.Size(467, 22);
            this.nohp.TabIndex = 11;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(79, 247);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(467, 22);
            this.email.TabIndex = 9;
            // 
            // alamat
            // 
            this.alamat.Location = new System.Drawing.Point(79, 159);
            this.alamat.Multiline = true;
            this.alamat.Name = "alamat";
            this.alamat.Size = new System.Drawing.Size(467, 71);
            this.alamat.TabIndex = 7;
            // 
            // nama
            // 
            this.nama.Location = new System.Drawing.Point(79, 81);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(467, 22);
            this.nama.TabIndex = 3;
            // 
            // npm
            // 
            this.npm.Location = new System.Drawing.Point(79, 43);
            this.npm.Name = "npm";
            this.npm.Size = new System.Drawing.Size(467, 22);
            this.npm.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "No HP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Alamat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Angkatan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NPM";
            // 
            // gbActBtn
            // 
            this.gbActBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbActBtn.Controls.Add(this.btnHapus);
            this.gbActBtn.Controls.Add(this.btnUbah);
            this.gbActBtn.Controls.Add(this.btnSimpan);
            this.gbActBtn.Controls.Add(this.btnRefresh);
            this.gbActBtn.Location = new System.Drawing.Point(624, 415);
            this.gbActBtn.Name = "gbActBtn";
            this.gbActBtn.Size = new System.Drawing.Size(370, 217);
            this.gbActBtn.TabIndex = 2;
            this.gbActBtn.TabStop = false;
            this.gbActBtn.Text = "Tombol Action";
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(25, 164);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(330, 30);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(25, 118);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(330, 30);
            this.btnUbah.TabIndex = 2;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(25, 72);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(330, 30);
            this.btnSimpan.TabIndex = 1;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnRefresh.Location = new System.Drawing.Point(25, 26);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(330, 30);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // gbSearch
            // 
            this.gbSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbSearch.Controls.Add(this.tbCariData);
            this.gbSearch.Controls.Add(this.label7);
            this.gbSearch.Location = new System.Drawing.Point(624, 306);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(369, 103);
            this.gbSearch.TabIndex = 3;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Form Pencarian";
            // 
            // tbCariData
            // 
            this.tbCariData.Location = new System.Drawing.Point(76, 40);
            this.tbCariData.Name = "tbCariData";
            this.tbCariData.Size = new System.Drawing.Size(279, 22);
            this.tbCariData.TabIndex = 1;
            this.tbCariData.TextChanged += new System.EventHandler(this.tbCariData_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cari Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 644);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.gbActBtn);
            this.Controls.Add(this.gbFDataMhs);
            this.Controls.Add(this.gbTDataMhs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbTDataMhs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataMahasiswa)).EndInit();
            this.gbFDataMhs.ResumeLayout(false);
            this.gbFDataMhs.PerformLayout();
            this.gbActBtn.ResumeLayout(false);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTDataMhs;
        private System.Windows.Forms.GroupBox gbFDataMhs;
        private System.Windows.Forms.GroupBox gbActBtn;
        private System.Windows.Forms.ComboBox angkatan;
        private System.Windows.Forms.TextBox nohp;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox alamat;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.TextBox npm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataMahasiswa;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.TextBox tbCariData;
        private System.Windows.Forms.Label label7;
    }
}

