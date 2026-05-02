namespace HastaneOtomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnHastaKayit = new Button();
            btnRandevuSistemi = new Button();
            btnDoktorGirisi = new Button();
            btnRandevuListele = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnHastaKayit
            // 
            btnHastaKayit.BackColor = SystemColors.ActiveCaptionText;
            btnHastaKayit.FlatStyle = FlatStyle.Flat;
            btnHastaKayit.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnHastaKayit.ForeColor = SystemColors.ButtonHighlight;
            btnHastaKayit.Location = new Point(264, 480);
            btnHastaKayit.Name = "btnHastaKayit";
            btnHastaKayit.Size = new Size(181, 57);
            btnHastaKayit.TabIndex = 1;
            btnHastaKayit.Text = "Hasta Kayıt";
            btnHastaKayit.UseVisualStyleBackColor = false;
            btnHastaKayit.Click += button2_Click;
            // 
            // btnRandevuSistemi
            // 
            btnRandevuSistemi.BackColor = SystemColors.ActiveCaptionText;
            btnRandevuSistemi.FlatStyle = FlatStyle.Flat;
            btnRandevuSistemi.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnRandevuSistemi.ForeColor = SystemColors.ButtonHighlight;
            btnRandevuSistemi.Location = new Point(482, 480);
            btnRandevuSistemi.Name = "btnRandevuSistemi";
            btnRandevuSistemi.Size = new Size(181, 57);
            btnRandevuSistemi.TabIndex = 3;
            btnRandevuSistemi.Text = "Randevu Sistemi";
            btnRandevuSistemi.UseVisualStyleBackColor = false;
            btnRandevuSistemi.Click += btnRandevuSistemi_Click;
            // 
            // btnDoktorGirisi
            // 
            btnDoktorGirisi.BackColor = SystemColors.ActiveCaptionText;
            btnDoktorGirisi.FlatStyle = FlatStyle.Flat;
            btnDoktorGirisi.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDoktorGirisi.ForeColor = SystemColors.ButtonHighlight;
            btnDoktorGirisi.Location = new Point(41, 480);
            btnDoktorGirisi.Name = "btnDoktorGirisi";
            btnDoktorGirisi.Size = new Size(181, 57);
            btnDoktorGirisi.TabIndex = 4;
            btnDoktorGirisi.Text = "  Yetkili Giriş";
            btnDoktorGirisi.UseVisualStyleBackColor = false;
            btnDoktorGirisi.Click += btnGiris_Click;
            // 
            // btnRandevuListele
            // 
            btnRandevuListele.BackColor = SystemColors.ActiveCaptionText;
            btnRandevuListele.FlatStyle = FlatStyle.Flat;
            btnRandevuListele.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnRandevuListele.ForeColor = SystemColors.ButtonHighlight;
            btnRandevuListele.Location = new Point(705, 480);
            btnRandevuListele.Name = "btnRandevuListele";
            btnRandevuListele.Size = new Size(181, 57);
            btnRandevuListele.TabIndex = 5;
            btnRandevuListele.Text = "Randevu Listesi";
            btnRandevuListele.UseVisualStyleBackColor = false;
            btnRandevuListele.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Gemini_Generated_Image_gkptvfgkptvfgkpt;
            pictureBox1.Location = new Point(207, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(456, 296);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(916, 635);
            Controls.Add(pictureBox1);
            Controls.Add(btnRandevuListele);
            Controls.Add(btnDoktorGirisi);
            Controls.Add(btnRandevuSistemi);
            Controls.Add(btnHastaKayit);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HastaneOtomasyonSistemi -Ana Menü";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Button button3;
        private Button button1;
        private Button button4;
        private Button btnDoktorGirisi;
        private Button btnHastaKayit;
        private Button btnRandevuSistemi;
        private Button btnRandevuListesi;
        private Button btnRandevuListele;
        private PictureBox pictureBox1;
    }
}
