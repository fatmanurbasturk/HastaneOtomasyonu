using System.Data.SqlClient;



namespace HastaneOtomasyonu
{
    public partial class Form1 : Form
    {
        RandevuListelemeFormu frmListe;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string adres = @"Data Source=LAPTOP-GUJ4DHHL\SQLEXPRESS;Initial Catalog=HastaneDB;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection baglanti = new SqlConnection(adres);

            HastaKayitFormu hst = new HastaKayitFormu();
            hst.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (frmListe == null || frmListe.IsDisposed)
            {
                frmListe = new RandevuListelemeFormu();
            }
            frmListe.Show();
        }

        private void btnRandevuSistemi_Click(object sender, EventArgs e)
        {
            RandevuKayitFormu frmKayit = new RandevuKayitFormu();
            frmKayit.Show();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            // Doktor giriş formunu açar
            YetkiliGirisi frm = new YetkiliGirisi();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            // Giriş yapılmadan önce sadece giriş butonu aktif kalsın
            btnHastaKayit.Enabled = false; // Hasta Kayıt
            btnRandevuListele.Enabled = false; // Randevu Listeleme
            btnRandevuSistemi.Enabled = false; // Randevu Kayıt
        }
    }
    }

