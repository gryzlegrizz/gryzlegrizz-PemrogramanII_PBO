namespace P9_714220046.view
{
    partial class FormNilai
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
            this.tbCariData = new System.Windows.Forms.TextBox();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cbnpm = new System.Windows.Forms.ComboBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.gbActBtn = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbFDataMhs = new System.Windows.Forms.GroupBox();
            this.tbnama = new System.Windows.Forms.TextBox();
            this.tbnilai = new System.Windows.Forms.TextBox();
            this.cbmatkul = new System.Windows.Forms.ComboBox();
            this.cbkategori = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataNilai = new System.Windows.Forms.DataGridView();
            this.gbTDataMhs = new System.Windows.Forms.GroupBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.gbSearch.SuspendLayout();
            this.gbActBtn.SuspendLayout();
            this.gbFDataMhs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNilai)).BeginInit();
            this.gbTDataMhs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCariData
            // 
            this.tbCariData.Location = new System.Drawing.Point(76, 23);
            this.tbCariData.Name = "tbCariData";
            this.tbCariData.Size = new System.Drawing.Size(279, 22);
            this.tbCariData.TabIndex = 1;
            this.tbCariData.TextChanged += new System.EventHandler(this.tbCariData_TextChanged);
            // 
            // gbSearch
            // 
            this.gbSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbSearch.Controls.Add(this.btnExport);
            this.gbSearch.Controls.Add(this.tbCariData);
            this.gbSearch.Controls.Add(this.label7);
            this.gbSearch.Location = new System.Drawing.Point(623, 305);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(369, 103);
            this.gbSearch.TabIndex = 2;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Form Pencarian";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cari Data";
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
            // cbnpm
            // 
            this.cbnpm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbnpm.FormattingEnabled = true;
            this.cbnpm.Location = new System.Drawing.Point(79, 172);
            this.cbnpm.Name = "cbnpm";
            this.cbnpm.Size = new System.Drawing.Size(467, 24);
            this.cbnpm.TabIndex = 5;
            this.cbnpm.SelectedIndexChanged += new System.EventHandler(this.cbnpm_SelectedIndexChanged);
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
            // gbActBtn
            // 
            this.gbActBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbActBtn.Controls.Add(this.btnHapus);
            this.gbActBtn.Controls.Add(this.btnUbah);
            this.gbActBtn.Controls.Add(this.btnSimpan);
            this.gbActBtn.Controls.Add(this.btnRefresh);
            this.gbActBtn.Location = new System.Drawing.Point(623, 414);
            this.gbActBtn.Name = "gbActBtn";
            this.gbActBtn.Size = new System.Drawing.Size(370, 217);
            this.gbActBtn.TabIndex = 3;
            this.gbActBtn.TabStop = false;
            this.gbActBtn.Text = "Tombol Action";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nilai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "NPM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kategori";
            // 
            // gbFDataMhs
            // 
            this.gbFDataMhs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbFDataMhs.Controls.Add(this.tbnama);
            this.gbFDataMhs.Controls.Add(this.tbnilai);
            this.gbFDataMhs.Controls.Add(this.cbmatkul);
            this.gbFDataMhs.Controls.Add(this.cbkategori);
            this.gbFDataMhs.Controls.Add(this.cbnpm);
            this.gbFDataMhs.Controls.Add(this.label4);
            this.gbFDataMhs.Controls.Add(this.label3);
            this.gbFDataMhs.Controls.Add(this.label2);
            this.gbFDataMhs.Controls.Add(this.label1);
            this.gbFDataMhs.Location = new System.Drawing.Point(12, 305);
            this.gbFDataMhs.Name = "gbFDataMhs";
            this.gbFDataMhs.Size = new System.Drawing.Size(605, 326);
            this.gbFDataMhs.TabIndex = 1;
            this.gbFDataMhs.TabStop = false;
            this.gbFDataMhs.Text = "Form Input Nilai";
            // 
            // tbnama
            // 
            this.tbnama.Location = new System.Drawing.Point(79, 199);
            this.tbnama.Name = "tbnama";
            this.tbnama.Size = new System.Drawing.Size(467, 22);
            this.tbnama.TabIndex = 8;
            // 
            // tbnilai
            // 
            this.tbnilai.Location = new System.Drawing.Point(79, 238);
            this.tbnilai.Name = "tbnilai";
            this.tbnilai.Size = new System.Drawing.Size(467, 22);
            this.tbnilai.TabIndex = 7;
            // 
            // cbmatkul
            // 
            this.cbmatkul.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmatkul.FormattingEnabled = true;
            this.cbmatkul.Items.AddRange(new object[] {
            "Pemrograman I",
            "Pemrograman II",
            "Pemrograman II",
            "Pemrograman IV",
            "Literasi Data",
            "Sistem ERP",
            "RPL",
            "Metodologi Penelitian",
            "PKN",
            "General English I"});
            this.cbmatkul.Location = new System.Drawing.Point(79, 42);
            this.cbmatkul.Name = "cbmatkul";
            this.cbmatkul.Size = new System.Drawing.Size(467, 24);
            this.cbmatkul.TabIndex = 1;
            // 
            // cbkategori
            // 
            this.cbkategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkategori.FormattingEnabled = true;
            this.cbkategori.Items.AddRange(new object[] {
            "UTS",
            "UAS"});
            this.cbkategori.Location = new System.Drawing.Point(79, 107);
            this.cbkategori.Name = "cbkategori";
            this.cbkategori.Size = new System.Drawing.Size(467, 24);
            this.cbkategori.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matkul";
            // 
            // dataNilai
            // 
            this.dataNilai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataNilai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNilai.Location = new System.Drawing.Point(0, 21);
            this.dataNilai.Name = "dataNilai";
            this.dataNilai.RowHeadersWidth = 51;
            this.dataNilai.RowTemplate.Height = 24;
            this.dataNilai.Size = new System.Drawing.Size(980, 266);
            this.dataNilai.TabIndex = 0;
            this.dataNilai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataNilai_CellClick);
            // 
            // gbTDataMhs
            // 
            this.gbTDataMhs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbTDataMhs.Controls.Add(this.dataNilai);
            this.gbTDataMhs.Location = new System.Drawing.Point(12, 12);
            this.gbTDataMhs.Name = "gbTDataMhs";
            this.gbTDataMhs.Size = new System.Drawing.Size(981, 287);
            this.gbTDataMhs.TabIndex = 0;
            this.gbTDataMhs.TabStop = false;
            this.gbTDataMhs.Text = "Tabel Data Mahasiswa";
            // 
            // btnExport
            // 
            this.btnExport.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnExport.Location = new System.Drawing.Point(76, 52);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(279, 28);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export to Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // FormNilai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 644);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.gbActBtn);
            this.Controls.Add(this.gbFDataMhs);
            this.Controls.Add(this.gbTDataMhs);
            this.Name = "FormNilai";
            this.Text = "Form Nilai";
            this.Load += new System.EventHandler(this.FormNilai_Load);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.gbActBtn.ResumeLayout(false);
            this.gbFDataMhs.ResumeLayout(false);
            this.gbFDataMhs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNilai)).EndInit();
            this.gbTDataMhs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbCariData;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cbnpm;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.GroupBox gbActBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbFDataMhs;
        private System.Windows.Forms.TextBox tbnilai;
        private System.Windows.Forms.ComboBox cbmatkul;
        private System.Windows.Forms.ComboBox cbkategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataNilai;
        private System.Windows.Forms.GroupBox gbTDataMhs;
        private System.Windows.Forms.TextBox tbnama;
        private System.Windows.Forms.Button btnExport;
    }
}