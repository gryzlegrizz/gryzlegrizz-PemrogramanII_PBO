namespace P6_3_714220046
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
            this.labelHuruf = new System.Windows.Forms.Label();
            this.labelAngka = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.labelAngka1 = new System.Windows.Forms.Label();
            this.labelAngka2 = new System.Windows.Forms.Label();
            this.txtHuruf = new System.Windows.Forms.TextBox();
            this.txtAngka = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAngka1 = new System.Windows.Forms.TextBox();
            this.txtAngka2 = new System.Windows.Forms.TextBox();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHuruf
            // 
            this.labelHuruf.AutoSize = true;
            this.labelHuruf.Location = new System.Drawing.Point(51, 45);
            this.labelHuruf.Name = "labelHuruf";
            this.labelHuruf.Size = new System.Drawing.Size(38, 16);
            this.labelHuruf.TabIndex = 0;
            this.labelHuruf.Text = "Huruf";
            // 
            // labelAngka
            // 
            this.labelAngka.AutoSize = true;
            this.labelAngka.Location = new System.Drawing.Point(51, 101);
            this.labelAngka.Name = "labelAngka";
            this.labelAngka.Size = new System.Drawing.Size(46, 16);
            this.labelAngka.TabIndex = 0;
            this.labelAngka.Text = "Angka";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(51, 157);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(41, 16);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Email";
            // 
            // redLabel
            // 
            this.redLabel.AutoSize = true;
            this.redLabel.ForeColor = System.Drawing.Color.Red;
            this.redLabel.Location = new System.Drawing.Point(51, 213);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(123, 16);
            this.redLabel.TabIndex = 0;
            this.redLabel.Text = "*Angka 1 > Angka 2";
            // 
            // labelAngka1
            // 
            this.labelAngka1.AutoSize = true;
            this.labelAngka1.Location = new System.Drawing.Point(51, 269);
            this.labelAngka1.Name = "labelAngka1";
            this.labelAngka1.Size = new System.Drawing.Size(56, 16);
            this.labelAngka1.TabIndex = 0;
            this.labelAngka1.Text = "Angka 1";
            // 
            // labelAngka2
            // 
            this.labelAngka2.AutoSize = true;
            this.labelAngka2.Location = new System.Drawing.Point(51, 325);
            this.labelAngka2.Name = "labelAngka2";
            this.labelAngka2.Size = new System.Drawing.Size(49, 16);
            this.labelAngka2.TabIndex = 0;
            this.labelAngka2.Text = "Agka 2";
            // 
            // txtHuruf
            // 
            this.txtHuruf.Location = new System.Drawing.Point(255, 39);
            this.txtHuruf.Name = "txtHuruf";
            this.txtHuruf.Size = new System.Drawing.Size(216, 22);
            this.txtHuruf.TabIndex = 0;
            this.txtHuruf.Leave += new System.EventHandler(this.txtHuruf_Leave);
            // 
            // txtAngka
            // 
            this.txtAngka.Location = new System.Drawing.Point(255, 95);
            this.txtAngka.Name = "txtAngka";
            this.txtAngka.Size = new System.Drawing.Size(216, 22);
            this.txtAngka.TabIndex = 1;
            this.txtAngka.Leave += new System.EventHandler(this.txtAngka_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(255, 151);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(216, 22);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtAngka1
            // 
            this.txtAngka1.Location = new System.Drawing.Point(255, 263);
            this.txtAngka1.Name = "txtAngka1";
            this.txtAngka1.Size = new System.Drawing.Size(216, 22);
            this.txtAngka1.TabIndex = 3;
            this.txtAngka1.Leave += new System.EventHandler(this.txtAngka1_Leave);
            // 
            // txtAngka2
            // 
            this.txtAngka2.Location = new System.Drawing.Point(255, 319);
            this.txtAngka2.Name = "txtAngka2";
            this.txtAngka2.Size = new System.Drawing.Size(216, 22);
            this.txtAngka2.TabIndex = 4;
            this.txtAngka2.Leave += new System.EventHandler(this.txtAngka2_Leave);
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(530, 450);
            this.Controls.Add(this.txtAngka2);
            this.Controls.Add(this.txtAngka1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAngka);
            this.Controls.Add(this.txtHuruf);
            this.Controls.Add(this.labelAngka2);
            this.Controls.Add(this.labelAngka1);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelAngka);
            this.Controls.Add(this.labelHuruf);
            this.Name = "Form1";
            this.Text = "Validasi";
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHuruf;
        private System.Windows.Forms.Label labelAngka;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label labelAngka1;
        private System.Windows.Forms.Label labelAngka2;
        private System.Windows.Forms.TextBox txtHuruf;
        private System.Windows.Forms.TextBox txtAngka;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAngka1;
        private System.Windows.Forms.TextBox txtAngka2;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.ErrorProvider epCorrect;
    }
}

