namespace HastaneOtomasyonu
{
    partial class RandevuKayitFormu
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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            btnKaydet = new Button();
            dateTimePicker1 = new DateTimePicker();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(457, 104);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(457, 188);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 1;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = SystemColors.ActiveCaptionText;
            btnKaydet.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKaydet.ForeColor = SystemColors.ButtonHighlight;
            btnKaydet.Location = new Point(472, 645);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(185, 58);
            btnKaydet.TabIndex = 2;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnRandevuKaydet_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(457, 302);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(457, 417);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(528, 126);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(154, 104);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 5;
            label1.Text = "Hasta Seç";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(154, 191);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 6;
            label2.Text = "Doktor Seç";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(154, 308);
            label3.Name = "label3";
            label3.Size = new Size(138, 25);
            label3.TabIndex = 7;
            label3.Text = "Randevu Tarihi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(154, 474);
            label4.Name = "label4";
            label4.Size = new Size(133, 25);
            label4.TabIndex = 8;
            label4.Text = "Hasta Şikayeti";
            // 
            // RandevuKayitFormu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 941);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnKaydet);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name = "RandevuKayitFormu";
            Text = "RandevuFormu";
            Load += RandevuFormu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button btnRandevuKaydet;
        private DateTimePicker dateTimePicker1;
        private RichTextBox richTextBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnKaydet;
    }
}