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
    public partial class YetkiliGirisi : Form
    {
        public YetkiliGirisi()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {

            // Şimdilik basit bir kontrol yapalım, ileride veritabanına bağlarız


           
            // Senin bilgisayarındaki SQL bağlantı adresi
            string adres = @"Data Source=LAPTOP-GUJ4DHHL\SQLEXPRESS;Initial Catalog=HastaneDB;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection baglanti = new SqlConnection(adres))
            {
                baglanti.Open();
                // Artık Gorevliler tablosundan kontrol ediyoruz
                string sorgu = "SELECT * FROM Gorevliler WHERE KullaniciAdi=@p1 AND Sifre=@p2";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@p1", txtKullanici.Text);
                komut.Parameters.AddWithValue("@p2", txtSifre.Text);

                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read()) // Eğer kullanıcı adı ve şifre doğruysa
                {
                    MessageBox.Show("Sistem Yetkilisi Girişi Başarılı!");

                    // Form1'deki butonları bulup aktif ediyoruz
                    Form1 anaForm = (Form1)Application.OpenForms["Form1"];
                    if (anaForm != null)
                    {
                        anaForm.Controls["btnHastaKayit"].Enabled = true;
                        anaForm.Controls["btnRandevuListele"].Enabled = true;
                        anaForm.Controls["btnRandevuSistemi"].Enabled = true;
                    }

                    this.Close(); // Giriş formunu kapat
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş! Lütfen yetkili bilgilerinizi kontrol edin.");
                }
            }
        }
    }
    }
    

