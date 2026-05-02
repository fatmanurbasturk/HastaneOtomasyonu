using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneOtomasyonu
{
    public partial class HastaKayitFormu : Form
    {
        public HastaKayitFormu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string adres = @"Data Source=LAPTOP-GUJ4DHHL\SQLEXPRESS;Initial Catalog=HastaneDB;Integrated Security=True;TrustServerCertificate=True";
           
            SqlConnection baglanti = new SqlConnection(adres);

            try
            {
                baglanti.Open();
                MessageBox.Show("Bağlanılan Veritabanı: " + baglanti.Database);
                string sorgu = "INSERT INTO Hastalar (Tc, Ad, Soyad) VALUES (@p1, @p2, @p3)";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@p1", textBox1.Text);
                komut.Parameters.AddWithValue("@p2", textBox2.Text);
                komut.Parameters.AddWithValue("@p3", textBox3.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Hasta Kaydı Başarıyla Yapılmıştır.");
            }
            catch(Exception hata)
            {
                MessageBox.Show("Kayıt Sırasında Hata Oluştu. Tekrar Deneyiniz.");
            }
        }
    }
}
