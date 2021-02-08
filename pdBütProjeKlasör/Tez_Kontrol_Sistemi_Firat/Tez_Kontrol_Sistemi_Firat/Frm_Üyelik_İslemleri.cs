using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Tez_Kontrol_Sistemi_Firat
{
    public partial class Frm_Üyelik_İslemleri : Form
    {
        // VERİTABANI KOMUTLARI
        SqlConnection Baglanti = new SqlConnection("Data Source=DESKTOP-R6M9ALH\\SQLEXPRESS;Initial Catalog=Tez_Kontrol;Integrated Security=True");
        SqlCommand Komut;
        SqlDataReader Reading;
        SqlDataAdapter Adaptering;
        public Frm_Üyelik_İslemleri()
        {
            InitializeComponent();
        }
        public static string Adi;
        public static string Soyadi;
        public static string Ögr_Nosu;
        public static string Özel_Sifre;
        private void button_Admin_Giris_Click(object sender, EventArgs e)
        {
            string Ögr_No = textBox_Ögrenci_No.Text;
            string Özel_Sifresi = textBox_Özel_Sifre.Text;

            if (textBox_Ögrenci_No.Text == "" && textBox_Özel_Sifre.Text == "")
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

                    Adaptering = new SqlDataAdapter("SELECT Ögrenci_No,Özel_Sifre FROM Login_Data", Baglanti);
                    Komut = new SqlCommand(Ögr_No + Özel_Sifresi);
                    Komut.CommandText = "SELECT Ögrenci_No,Özel_Sifre FROM Login_Data WHERE Ögrenci_No='" + textBox_Ögrenci_No.Text + "'AND Özel_Sifre='" + textBox_Özel_Sifre.Text + "'";
                    Komut.Connection = Baglanti;
                    Reading = Komut.ExecuteReader();
                    if (Reading.Read() == true)
                    {
                        // K.ADI VE ŞİFRE VERİTABANINDA KAYITLI İSE YAPILAN İŞLEMLER
                        MessageBox.Show("Giriş Başarılı", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Frm_Üyeler Üye_Kontrol_Ekran_Ac = new Frm_Üyeler();
                        this.Hide();
                        Üye_Kontrol_Ekran_Ac.ShowDialog();
                    }
                    else
                    {
                        // K.ADI VE ŞİFRE VERİTABANINDA KAYITLI DEĞİL İSE YAPILAN İŞLEMLER
                        MessageBox.Show("Bağlantı Yapılamadı...", "Hata :", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button_Cıkıs_Yap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Login giris = new Frm_Login();
            giris.ShowDialog();
        }
    }
}
