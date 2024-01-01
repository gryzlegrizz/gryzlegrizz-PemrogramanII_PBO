namespace P9_714220046.view
{
    partial class FormTransaksiBarang
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
            this.gbTDataTransaksi = new System.Windows.Forms.GroupBox();
            this.dataTransaksi = new System.Windows.Forms.DataGridView();
            this.gbFDataMhs = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbQty = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbNamaBarang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.cbID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.tbCariData = new System.Windows.Forms.TextBox();
            this.gbActBtn = new System.Windows.Forms.GroupBox();
            this.gbTDataTransaksi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTransaksi)).BeginInit();
            this.gbFDataMhs.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.gbActBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTDataTransaksi
            // 
            this.gbTDataTransaksi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbTDataTransaksi.Controls.Add(this.dataTransaksi);
            this.gbTDataTransaksi.Location = new System.Drawing.Point(13, 13);
            this.gbTDataTransaksi.Name = "gbTDataTransaksi";
            this.gbTDataTransaksi.Size = new System.Drawing.Size(981, 287);
            this.gbTDataTransaksi.TabIndex = 4;
            this.gbTDataTransaksi.TabStop = false;
            this.gbTDataTransaksi.Text = "Tabel Data Transaksi Barang";
            // 
            // dataTransaksi
            // 
            this.dataTransaksi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTransaksi.Location = new System.Drawing.Point(0, 21);
            this.dataTransaksi.Name = "dataTransaksi";
            this.dataTransaksi.RowHeadersWidth = 51;
            this.dataTransaksi.RowTemplate.Height = 24;
            this.dataTransaksi.Size = new System.Drawing.Size(980, 266);
            this.dataTransaksi.TabIndex = 0;
            this.dataTransaksi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTransaksi_CellClick);
            this.dataTransaksi.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataTransaksi_CellFormatting);
            // 
            // gbFDataMhs
            // 
            this.gbFDataMhs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbFDataMhs.Controls.Add(this.label8);
            this.gbFDataMhs.Controls.Add(this.tbTotal);
            this.gbFDataMhs.Controls.Add(this.tbQty);
            this.gbFDataMhs.Controls.Add(this.groupBox1);
            this.gbFDataMhs.Controls.Add(this.label4);
            this.gbFDataMhs.Controls.Add(this.label3);
            this.gbFDataMhs.Controls.Add(this.label1);
            this.gbFDataMhs.Location = new System.Drawing.Point(13, 306);
            this.gbFDataMhs.Name = "gbFDataMhs";
            this.gbFDataMhs.Size = new System.Drawing.Size(605, 326);
            this.gbFDataMhs.TabIndex = 5;
            this.gbFDataMhs.TabStop = false;
            this.gbFDataMhs.Text = "Form Input Nilai";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(66, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Rp";
            // 
            // tbTotal
            // 
            this.tbTotal.Enabled = false;
            this.tbTotal.Location = new System.Drawing.Point(97, 238);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(237, 22);
            this.tbTotal.TabIndex = 8;
            this.tbTotal.TextChanged += new System.EventHandler(this.tbTotal_TextChanged);
            // 
            // tbQty
            // 
            this.tbQty.Location = new System.Drawing.Point(97, 173);
            this.tbQty.Name = "tbQty";
            this.tbQty.Size = new System.Drawing.Size(237, 22);
            this.tbQty.TabIndex = 5;
            this.tbQty.TextChanged += new System.EventHandler(this.tbQty_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbNamaBarang);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbHarga);
            this.groupBox1.Controls.Add(this.cbID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(97, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 119);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // tbNamaBarang
            // 
            this.tbNamaBarang.Enabled = false;
            this.tbNamaBarang.Location = new System.Drawing.Point(6, 91);
            this.tbNamaBarang.Name = "tbNamaBarang";
            this.tbNamaBarang.ReadOnly = true;
            this.tbNamaBarang.Size = new System.Drawing.Size(231, 22);
            this.tbNamaBarang.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(278, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Harga Barang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(250, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Rp";
            // 
            // tbHarga
            // 
            this.tbHarga.Enabled = false;
            this.tbHarga.Location = new System.Drawing.Point(281, 90);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.ReadOnly = true;
            this.tbHarga.Size = new System.Drawing.Size(213, 22);
            this.tbHarga.TabIndex = 2;
            this.tbHarga.TextChanged += new System.EventHandler(this.tbHarga_TextChanged);
            // 
            // cbID
            // 
            this.cbID.FormattingEnabled = true;
            this.cbID.Location = new System.Drawing.Point(6, 21);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(231, 24);
            this.cbID.TabIndex = 0;
            this.cbID.SelectedIndexChanged += new System.EventHandler(this.cbID_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Barang";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cari Data";
            // 
            // gbSearch
            // 
            this.gbSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbSearch.Controls.Add(this.tbCariData);
            this.gbSearch.Controls.Add(this.label7);
            this.gbSearch.Location = new System.Drawing.Point(624, 306);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(369, 103);
            this.gbSearch.TabIndex = 6;
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
            // FormTransaksiBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 644);
            this.Controls.Add(this.gbTDataTransaksi);
            this.Controls.Add(this.gbFDataMhs);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.gbActBtn);
            this.Name = "FormTransaksiBarang";
            this.Text = "FormTransaksiBarang";
            this.Load += new System.EventHandler(this.FormTransaksiBarang_Load);
            this.gbTDataTransaksi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTransaksi)).EndInit();
            this.gbFDataMhs.ResumeLayout(false);
            this.gbFDataMhs.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.gbActBtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTDataTransaksi;
        private System.Windows.Forms.DataGridView dataTransaksi;
        private System.Windows.Forms.GroupBox gbFDataMhs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.TextBox tbCariData;
        private System.Windows.Forms.GroupBox gbActBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.ComboBox cbID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TextBox tbQty;
        private System.Windows.Forms.TextBox tbNamaBarang;
        private System.Windows.Forms.Label label6;
    }
}