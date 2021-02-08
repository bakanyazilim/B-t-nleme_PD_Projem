using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Tez_Kontrol_Sistemi_Firat
{
    public partial class Frm_Login : Form
    {
        // VERİTABANI KOMUTLARI
        SqlConnection Baglanti = new SqlConnection("Data Source=DESKTOP-R6M9ALH\\SQLEXPRESS;Initial Catalog=Tez_Kontrol;Integrated Security=True");
        SqlCommand Komut;
        SqlDataReader Reading;
        SqlDataAdapter Adaptering;
        public Frm_Login()
        {
            InitializeComponent();
        }
        // DEĞİŞKENLER
        public static string Adi;
        public static string Soyadi;
        public static string K_Adi;
        public static string Sifre;
        private void toolStripComboBox_Kullanım_Click(object sender, EventArgs e)
        {
            // KULLANIM ? TUŞUNA BASILINCA OLAN İŞLEMLER
            MessageBox.Show("Sistemi Kullanmaya Başlmak İçin K.Adı Kısmına Sisteme Kayıtlı Olan K.Adınızı VE  "
                +" Sifre Kısmına Sisteme Kayıtlı Olan Sifrenizi Doğru Bir Sekilde Giriniz","Kullanım Açıklama",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void toolStripComboBox_Unuttum_Click(object sender, EventArgs e)
        {
            // SİFRE UNUTMAK TUŞUNA BASILINCA OLAN İŞLEMLER
            MessageBox.Show("Eğer Sistemi Kullanırken Kaydettiğiniz Sifrenizi Unutursanız Sayfada Bulunan Şifrem Kayıp Butonuna Tıklayıp Karşınıza Çıkan Sayfada "
    + "  E Posta Kısmına Sisteme Kayıtlı Olan E Postanızı Doğru Bir Sekilde Giriniz VE E Posta At Butonuna Tıklayınız","Sifremizi Unuttuysak",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void toolStripComboBox_Yardım_Click(object sender, EventArgs e)
        {
            // YARDIM TUŞUNA BASILINCA OLAN İŞLEMLER
            MessageBox.Show("Sistemi İlk Defa Kullanacaksınız Sayfada Bulunan Üye Ol Butonundan Sisteme Üye Olmanız Tavsiye Edilir Üye Olurken   "
               + " Tüm Bilgilerinizi Doğru Bir Sekilde Giriniz Aksi Halde Sisteme Kayıt Olamazsınız","KISA YARDIM",MessageBoxButtons.OK,MessageBoxIcon.Question);
        }
        private void ToolStripMenuItem_Üye_İslem_Click(object sender, EventArgs e)
        {
            // ÜYE İŞLEMLERİ TUŞUNA BASILINCA OLAN İŞLEMLER
            MessageBox.Show("Sistemi İlk Defa Kullanacaksınız Sayfada Bulunan Üye Ol Butonundan Sisteme Üye Olmanız Tavsiye Edilir Üye Olurken   "
              + " Tüm Bilgilerinizi Doğru Bir Sekilde Giriniz Aksi Halde Sisteme Kayıt Olamazsınız TÜM ÜYELİK İŞLEMLERİNİZİ ÜYE OL BUTONUNDAN GERÇEKLEŞTİREBİLİRSİNİZ (ÜYE EKLEME,ÜYE SİLME,HESAP GÜNCELLEME)", "ÜYELİK İŞLEMLERİ", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
        private void button_Giris_Click(object sender, EventArgs e)
        {
            // GİRİŞ BUTONUNA BASILINCA GERÇEKLEŞEN İŞLEMLER
            string K_adi = textBox_Kullanıcı_Adi.Text;
            string Sifre = textBox_Parola.Text;
            if (textBox_Kullanıcı_Adi.Text=="" && textBox_Parola.Text=="")
            {
                // TEXTBOXLAR BOŞ BIRAKILIRSA ÇIKAN UYARI
                MessageBox.Show("Bilgilerinizden Bir Veya Daha Fazlası Eksik Veya Yanlış Görünüyor Lütfen tüm Alanları Eksiksiz VE Sistemdeki Kayıtlı " +
                    "Bilgilerinizle Doğru Eşleşecek Şekilde Doldurup Tekrar Deneyiniz ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                //VERİTABANI BAĞLANTISI
                Baglanti.Open();
                try
                {

                    Adaptering = new SqlDataAdapter("SELECT K_Adi,Sifre FROM Login_Data", Baglanti);
                    Komut = new SqlCommand(K_adi+Sifre);
                    Komut.CommandText = "SELECT K_Adi, Sifre FROM Login_Data WHERE K_Adi='" + textBox_Kullanıcı_Adi.Text + "'AND Sifre='" + textBox_Parola.Text + "'";
                    Komut.Connection = Baglanti;
                    Reading = Komut.ExecuteReader();
                    if (Reading.Read() == true)
                    {
                        // K.ADI VE ŞİFRE VERİTABANINDA KAYITLI İSE YAPILAN İŞLEMLER
                        MessageBox.Show("Giriş Başarılı", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Frm_Kontrol_Ekrani Kontrol_Ekran_Ac = new Frm_Kontrol_Ekrani();
                        this.Hide();
                        Kontrol_Ekran_Ac.ShowDialog();
                    }
                    else
                    {
                        // K.ADI VE ŞİFRE VERİTABANINDA KAYITLI DEĞİL İSE YAPILAN İŞLEMLER
                        MessageBox.Show("Bağlantı Yapılamadı..." , "Hata :" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Baglanti.Close();
                    }
                 }
                catch (Exception hata)
                {
                    // HATA OLUŞMASI DURUMUNDA YAPILAN İŞLEM
                    MessageBox.Show("Bağlantı Yapılamadı... Nedeni: \n" + hata.ToString(), "Hata :" + hata.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Baglanti.Close();
        }

        private void button_Sifre_Unuttum_Click(object sender, EventArgs e)
        {
            // parolamı unuttum butonuna tıklanması durumunda geçerli formun gizlenmesi ve parolamı unuttum formunun açılması.

            this.Hide();
            Frm_Parola_Hatırlatma Sifrem = new Frm_Parola_Hatırlatma();
            Sifrem.ShowDialog();
        }

        private void button_Üye_Ol_Click(object sender, EventArgs e)
        {
            Frm_Üyelik_İslemleri Üyelikler = new Frm_Üyelik_İslemleri();
            Üyelikler.ShowDialog();
        }
    }
}
