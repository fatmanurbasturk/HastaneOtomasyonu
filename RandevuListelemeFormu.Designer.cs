namespace HastaneOtomasyonu
{
    partial class RandevuListelemeFormu
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            randevuyuSilToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            txtArama = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Location = new Point(153, 247);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1074, 689);
            dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { randevuyuSilToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(149, 26);
            // 
            // randevuyuSilToolStripMenuItem
            // 
            randevuyuSilToolStripMenuItem.Name = "randevuyuSilToolStripMenuItem";
            randevuyuSilToolStripMenuItem.Size = new Size(148, 22);
            randevuyuSilToolStripMenuItem.Text = "Randevuyu Sil";
            randevuyuSilToolStripMenuItem.Click += randevuyuSilToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(165, 202);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 1;
            label1.Text = "Hasta Adı Ara:";
            // 
            // txtArama
            // 
            txtArama.Location = new Point(326, 202);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(163, 23);
            txtArama.TabIndex = 2;
            txtArama.TextChanged += txtArama_TextChanged;
            // 
            // RandevuListelemeFormu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1364, 1044);
            Controls.Add(txtArama);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "RandevuListelemeFormu";
            Text = "RandevuListele";
            Load += RandevuListele_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem randevuyuSilToolStripMenuItem;
        private Label label1;
        private TextBox txtArama;
    }
}