namespace P6_4_714220046
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNamaDepan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNamaBelakang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNoTelp = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbLap3 = new System.Windows.Forms.RadioButton();
            this.rbLap2 = new System.Windows.Forms.RadioButton();
            this.rbLap1 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.jamPesanan = new System.Windows.Forms.DateTimePicker();
            this.tglPesanan = new System.Windows.Forms.DateTimePicker();
            this.rb90menit = new System.Windows.Forms.RadioButton();
            this.rb60menit = new System.Windows.Forms.RadioButton();
            this.rb45menit = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnPesan = new System.Windows.Forms.Button();
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTutup = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Pemesanan Lapangan Badminton";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Pemesan";
            // 
            // txtNamaDepan
            // 
            this.txtNamaDepan.Location = new System.Drawing.Point(18, 112);
            this.txtNamaDepan.Name = "txtNamaDepan";
            this.txtNamaDepan.Size = new System.Drawing.Size(519, 22);
            this.txtNamaDepan.TabIndex = 3;
            this.txtNamaDepan.Leave += new System.EventHandler(this.txtNamaDepan_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama Depan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nama Belakang";
            // 
            // txtNamaBelakang
            // 
            this.txtNamaBelakang.Location = new System.Drawing.Point(18, 169);
            this.txtNamaBelakang.Name = "txtNamaBelakang";
            this.txtNamaBelakang.Size = new System.Drawing.Size(519, 22);
            this.txtNamaBelakang.TabIndex = 5;
            this.txtNamaBelakang.Leave += new System.EventHandler(this.txtNamaBelakang_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nomor Telepon Pemesan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Alamat Email Pemesan";
            // 
            // txtNoTelp
            // 
            this.txtNoTelp.Location = new System.Drawing.Point(18, 223);
            this.txtNoTelp.Name = "txtNoTelp";
            this.txtNoTelp.Size = new System.Drawing.Size(232, 22);
            this.txtNoTelp.TabIndex = 7;
            this.txtNoTelp.Leave += new System.EventHandler(this.txtNoTelp_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(305, 223);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(232, 22);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FloralWhite;
            this.groupBox1.Controls.Add(this.rbLap3);
            this.groupBox1.Controls.Add(this.rbLap2);
            this.groupBox1.Controls.Add(this.rbLap1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(18, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 186);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // rbLap3
            // 
            this.rbLap3.AutoSize = true;
            this.rbLap3.Location = new System.Drawing.Point(13, 112);
            this.rbLap3.Name = "rbLap3";
            this.rbLap3.Size = new System.Drawing.Size(99, 20);
            this.rbLap3.TabIndex = 4;
            this.rbLap3.TabStop = true;
            this.rbLap3.Text = "Lapangan 3";
            this.rbLap3.UseVisualStyleBackColor = true;
            // 
            // rbLap2
            // 
            this.rbLap2.AutoSize = true;
            this.rbLap2.Location = new System.Drawing.Point(13, 76);
            this.rbLap2.Name = "rbLap2";
            this.rbLap2.Size = new System.Drawing.Size(99, 20);
            this.rbLap2.TabIndex = 3;
            this.rbLap2.TabStop = true;
            this.rbLap2.Text = "Lapangan 2";
            this.rbLap2.UseVisualStyleBackColor = true;
            // 
            // rbLap1
            // 
            this.rbLap1.AutoSize = true;
            this.rbLap1.Location = new System.Drawing.Point(13, 40);
            this.rbLap1.Name = "rbLap1";
            this.rbLap1.Size = new System.Drawing.Size(99, 20);
            this.rbLap1.TabIndex = 2;
            this.rbLap1.TabStop = true;
            this.rbLap1.Text = "Lapangan 1";
            this.rbLap1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Pesan Lapangan";
            // 
            // jamPesanan
            // 
            this.jamPesanan.CustomFormat = "HH:mm";
            this.jamPesanan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.jamPesanan.Location = new System.Drawing.Point(27, 552);
            this.jamPesanan.Name = "jamPesanan";
            this.jamPesanan.Size = new System.Drawing.Size(506, 22);
            this.jamPesanan.TabIndex = 10;
            this.jamPesanan.Value = new System.DateTime(2023, 11, 7, 11, 49, 25, 0);
            // 
            // tglPesanan
            // 
            this.tglPesanan.Location = new System.Drawing.Point(27, 497);
            this.tglPesanan.Name = "tglPesanan";
            this.tglPesanan.Size = new System.Drawing.Size(506, 22);
            this.tglPesanan.TabIndex = 10;
            // 
            // rb90menit
            // 
            this.rb90menit.AutoSize = true;
            this.rb90menit.Location = new System.Drawing.Point(13, 112);
            this.rb90menit.Name = "rb90menit";
            this.rb90menit.Size = new System.Drawing.Size(77, 20);
            this.rb90menit.TabIndex = 8;
            this.rb90menit.TabStop = true;
            this.rb90menit.Text = "90 Menit";
            this.rb90menit.UseVisualStyleBackColor = true;
            // 
            // rb60menit
            // 
            this.rb60menit.AutoSize = true;
            this.rb60menit.Location = new System.Drawing.Point(13, 76);
            this.rb60menit.Name = "rb60menit";
            this.rb60menit.Size = new System.Drawing.Size(77, 20);
            this.rb60menit.TabIndex = 7;
            this.rb60menit.TabStop = true;
            this.rb60menit.Text = "60 Menit";
            this.rb60menit.UseVisualStyleBackColor = true;
            // 
            // rb45menit
            // 
            this.rb45menit.AutoSize = true;
            this.rb45menit.Location = new System.Drawing.Point(13, 40);
            this.rb45menit.Name = "rb45menit";
            this.rb45menit.Size = new System.Drawing.Size(77, 20);
            this.rb45menit.TabIndex = 6;
            this.rb45menit.TabStop = true;
            this.rb45menit.Text = "45 Menit";
            this.rb45menit.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Durasi Pesanan";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 533);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 16);
            this.label11.TabIndex = 9;
            this.label11.Text = "Waktu Pesanan";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 478);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Tanggal Pesanan";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(262, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Pesanan";
            // 
            // btnPesan
            // 
            this.btnPesan.BackColor = System.Drawing.Color.SpringGreen;
            this.btnPesan.ForeColor = System.Drawing.Color.Black;
            this.btnPesan.Location = new System.Drawing.Point(23, 597);
            this.btnPesan.Name = "btnPesan";
            this.btnPesan.Size = new System.Drawing.Size(102, 29);
            this.btnPesan.TabIndex = 11;
            this.btnPesan.Text = "Pesan";
            this.btnPesan.UseVisualStyleBackColor = false;
            this.btnPesan.Click += new System.EventHandler(this.btnPesan_Click);
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FloralWhite;
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.rb45menit);
            this.groupBox2.Controls.Add(this.rb90menit);
            this.groupBox2.Controls.Add(this.rb60menit);
            this.groupBox2.Location = new System.Drawing.Point(305, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 186);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // btnTutup
            // 
            this.btnTutup.BackColor = System.Drawing.Color.Red;
            this.btnTutup.ForeColor = System.Drawing.Color.White;
            this.btnTutup.Location = new System.Drawing.Point(435, 597);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(102, 29);
            this.btnTutup.TabIndex = 13;
            this.btnTutup.Text = "Tutup";
            this.btnTutup.UseVisualStyleBackColor = false;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(605, 638);
            this.Controls.Add(this.btnTutup);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.jamPesanan);
            this.Controls.Add(this.tglPesanan);
            this.Controls.Add(this.btnPesan);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNoTelp);
            this.Controls.Add(this.txtNamaBelakang);
            this.Controls.Add(this.txtNamaDepan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form Pemesanan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNamaDepan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNamaBelakang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNoTelp;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbLap3;
        private System.Windows.Forms.RadioButton rbLap2;
        private System.Windows.Forms.RadioButton rbLap1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rb90menit;
        private System.Windows.Forms.RadioButton rb60menit;
        private System.Windows.Forms.RadioButton rb45menit;
        private System.Windows.Forms.DateTimePicker tglPesanan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPesan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker jamPesanan;
        private System.Windows.Forms.ErrorProvider epCorrect;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTutup;
    }
}

