namespace HastaneOtomasyonu
{
    partial class YetkiliGirisi
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
            label1 = new Label();
            label2 = new Label();
            txtKullanici = new TextBox();
            txtSifre = new TextBox();
            btnGiris = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(23, 54);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 0;
            label1.Text = "KullanıcıAdı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(23, 127);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 1;
            label2.Text = "Şifre";
            // 
            // txtKullanici
            // 
            txtKullanici.Location = new Point(170, 56);
            txtKullanici.Name = "txtKullanici";
            txtKullanici.Size = new Size(152, 23);
            txtKullanici.TabIndex = 2;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(170, 127);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(152, 23);
            txtSifre.TabIndex = 3;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.Black;
            btnGiris.FlatStyle = FlatStyle.Flat;
            btnGiris.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGiris.ForeColor = SystemColors.Window;
            btnGiris.Location = new Point(430, 384);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(122, 46);
            btnGiris.TabIndex = 4;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // DoktorGirisFormu
            // 
            AcceptButton = btnGiris;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1018, 684);
            Controls.Add(btnGiris);
            Controls.Add(txtSifre);
            Controls.Add(txtKullanici);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "DoktorGirisFormu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yetkili Girişi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtKullanici;
        private TextBox txtSifre;
        private Button btnGiris;
    }
}