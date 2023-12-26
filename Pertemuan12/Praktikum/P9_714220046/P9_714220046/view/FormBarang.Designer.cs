namespace P9_714220046.view
{
    partial class FormBarang
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
            this.dataBarang = new System.Windows.Forms.DataGridView();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.tbCariData = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbActBtn = new System.Windows.Forms.GroupBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.gbFDataBarang = new System.Windows.Forms.GroupBox();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.tbNamaBarang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbTDataBarang = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataBarang)).BeginInit();
            this.gbSearch.SuspendLayout();
            this.gbActBtn.SuspendLayout();
            this.gbFDataBarang.SuspendLayout();
            this.gbTDataBarang.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataBarang
            // 
            this.dataBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBarang.Location = new System.Drawing.Point(0, 21);
            this.dataBarang.Name = "dataBarang";
            this.dataBarang.RowHeadersWidth = 51;
            this.dataBarang.RowTemplate.Height = 24;
            this.dataBarang.Size = new System.Drawing.Size(980, 369);
            this.dataBarang.TabIndex = 0;
            this.dataBarang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBarang_CellClick);
            this.dataBarang.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataBarang_CellFormatting);
            // 
            // gbSearch
            // 
            this.gbSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbSearch.Controls.Add(this.tbCariData);
            this.gbSearch.Controls.Add(this.label7);
            this.gbSearch.Location = new System.Drawing.Point(12, 569);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(606, 63);
            this.gbSearch.TabIndex = 6;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Form Pencarian";
            // 
            // tbCariData
            // 
            this.tbCariData.Location = new System.Drawing.Point(104, 37);
            this.tbCariData.Name = "tbCariData";
            this.tbCariData.Size = new System.Drawing.Size(467, 22);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Harga";
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
            this.gbActBtn.TabIndex = 7;
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
            // gbFDataBarang
            // 
            this.gbFDataBarang.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbFDataBarang.Controls.Add(this.tbHarga);
            this.gbFDataBarang.Controls.Add(this.tbNamaBarang);
            this.gbFDataBarang.Controls.Add(this.label2);
            this.gbFDataBarang.Controls.Add(this.label1);
            this.gbFDataBarang.Location = new System.Drawing.Point(13, 415);
            this.gbFDataBarang.Name = "gbFDataBarang";
            this.gbFDataBarang.Size = new System.Drawing.Size(605, 148);
            this.gbFDataBarang.TabIndex = 5;
            this.gbFDataBarang.TabStop = false;
            this.gbFDataBarang.Text = "Form Input Barang";
            // 
            // tbHarga
            // 
            this.tbHarga.Location = new System.Drawing.Point(103, 97);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(467, 22);
            this.tbHarga.TabIndex = 3;
            // 
            // tbNamaBarang
            // 
            this.tbNamaBarang.Location = new System.Drawing.Point(103, 43);
            this.tbNamaBarang.Name = "tbNamaBarang";
            this.tbNamaBarang.Size = new System.Drawing.Size(467, 22);
            this.tbNamaBarang.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Barang";
            // 
            // gbTDataBarang
            // 
            this.gbTDataBarang.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbTDataBarang.Controls.Add(this.dataBarang);
            this.gbTDataBarang.Location = new System.Drawing.Point(13, 13);
            this.gbTDataBarang.Name = "gbTDataBarang";
            this.gbTDataBarang.Size = new System.Drawing.Size(981, 396);
            this.gbTDataBarang.TabIndex = 4;
            this.gbTDataBarang.TabStop = false;
            this.gbTDataBarang.Text = "Tabel Data Barang";
            // 
            // FormBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 644);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.gbActBtn);
            this.Controls.Add(this.gbFDataBarang);
            this.Controls.Add(this.gbTDataBarang);
            this.Name = "FormBarang";
            this.Text = "Form Barang";
            this.Load += new System.EventHandler(this.FormBarang_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataBarang)).EndInit();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.gbActBtn.ResumeLayout(false);
            this.gbFDataBarang.ResumeLayout(false);
            this.gbFDataBarang.PerformLayout();
            this.gbTDataBarang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataBarang;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.TextBox tbCariData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbActBtn;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox gbFDataBarang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbTDataBarang;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.TextBox tbNamaBarang;
    }
}