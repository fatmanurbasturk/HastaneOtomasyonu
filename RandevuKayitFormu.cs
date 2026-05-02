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
    public partial class RandevuKayitFormu : Form
    {
        public RandevuKayitFormu()
        {
            InitializeComponent();
        }



        private void RandevuFormu_Load(object sender, EventArgs e)
        {
            string adres = @"Data Source=.\SQLEXPRESS;Initial Catalog=HastaneDB;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection baglanti = new SqlConnection(adres))
            {
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("SELECT Ad,Soyad FROM Hastalar", baglanti);
                    SqlDataReader oku = komut.ExecuteReader();

                    while (oku.Read())
                    {
                        comboBox1.Items.Add((oku["Ad"].ToString() + " " + oku["Soyad"].ToString()));
                    }
                    oku.Close();
                    // --- DOKTORLARI ÇEKME KODU BAŞLANGIÇ ---
                    SqlCommand komutDoktor = new SqlCommand("SELECT Ad, Soyad,Brans FROM Doktorlar", baglanti);
                    SqlDataReader okuDoktor = komutDoktor.ExecuteReader();

                    while (okuDoktor.Read())
                    {
                        // Burada comboBox2 senin doktorlar için kullandığın combo olmalı!
                        comboBox2.Items.Add(okuDoktor["Ad"].ToString() + " " + okuDoktor["Soyad"].ToString());
                    }
                    okuDoktor.Close(); // Okuyucuyu kapatmayı unutma
                                       // --- DOKTORLARI ÇEKME KODU BİTİŞ ---
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
        // RandevuFormu.cs içindeki Kaydet butonu


        private void btnRandevuKaydet_Click(object sender, EventArgs e)
        {
            string adres = @"Data Source=LAPTOP-GUJ4DHHL\SQLEXPRESS;Initial Catalog=HastaneDB;Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection baglanti = new SqlConnection(adres))
            {
                try
                {
                    baglanti.Open();
                    // BURAYA DİKKAT: Tablo adı 'Randevular' olmalı, 'Hastalar' değil!
                    string sorgu = "INSERT INTO Randevular (HastaID, DoktorID, Tarih, Sikayet) VALUES (@r1, @r2, @r3, @r4)";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);

                    komut.Parameters.AddWithValue("@r1", comboBox1.Text);
                    komut.Parameters.AddWithValue("@r2", comboBox2.Text);
                    komut.Parameters.AddWithValue("@r3", dateTimePicker1.Value);
                    komut.Parameters.AddWithValue("@r4", richTextBox1.Text);

                    komut.ExecuteNonQuery();
                    MessageBox.Show("Randevu başarıyla oluşturuldu!");
                    foreach (Form openForm in Application.OpenForms)
                    {
                        // Formun tipi senin verdiğin isme göre 'RandevuListeleme' veya 'RandevuListelemeFormu' olmalı
                        if (openForm is RandevuListelemeFormu listeFormu)
                        {
                            listeFormu.Listele();
                            break;
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                // Önce açık olan RandevuListeleme formunu buluyoruz
                RandevuListelemeFormu frm = (RandevuListelemeFormu)Application.OpenForms["RandevuListeleme"];

                // Eğer form açıksa içindeki Listele metodunu çalıştırıyoruz
                // Açık olan formu bulurken isme çok dikkat et
                var acikForm = Application.OpenForms["RandevuListeleme"];

                if (acikForm != null)
                {
                    // Formu bulursa içindeki Listele metodunu çağırır
                    ((RandevuListelemeFormu)acikForm).Listele();
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
