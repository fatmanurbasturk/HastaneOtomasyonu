using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class RandevuListelemeFormu : Form
    {
        public RandevuListelemeFormu()
        {
            InitializeComponent();
        }
        public void Listele()
        {
            try
            {
                string adres = @"Data Source=.\SQLEXPRESS;Initial Catalog=HastaneDB;Integrated Security=True;TrustServerCertificate=True";
                using (SqlConnection baglanti = new SqlConnection(adres))
                {
                    baglanti.Open();
                    string sorgu = "SELECT * FROM Randevular";
                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme hatası: " + ex.Message);
            }
        }
        private void RandevuListele_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void randevuyuSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Seçili satırdaki RandevuID'yi alıyoruz (ID sütununun 0. sütun olduğunu varsayıyorum)
                int seciliId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["RandevıID"].Value);

                DialogResult onay = MessageBox.Show("Bu randevuyu silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (onay == DialogResult.Yes)
                {
                    string adres = @"Data Source=.\SQLEXPRESS;Initial Catalog=HastaneDB;Integrated Security=True;TrustServerCertificate=True";
                    using (SqlConnection baglanti = new SqlConnection(adres))
                    {
                        baglanti.Open();
                        string sorgu = "DELETE FROM Randevular WHERE RandevıID=@id";
                        SqlCommand komut = new SqlCommand(sorgu, baglanti);
                        komut.Parameters.AddWithValue("@id", seciliId);
                        komut.ExecuteNonQuery();
                    }
                    MessageBox.Show("Randevu başarıyla silindi.");
                    Listele(); // Listeyi hemen tazele!
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı en solundan seçin.");
            }
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            string adres = @"Data Source=.\SQLEXPRESS;Initial Catalog=HastaneDB;Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection baglanti = new SqlConnection(adres))
            {
                // 'LIKE' komutu ile arama yapıyoruz. % işareti "devamı olabilir" demek.
                string sorgu = "SELECT * FROM Randevular WHERE HastaID LIKE @aranan + '%'";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                da.SelectCommand.Parameters.AddWithValue("@aranan", txtArama.Text);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
