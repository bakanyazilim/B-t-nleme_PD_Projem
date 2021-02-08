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
    public partial class Frm_Üye_Ekle : Form
    {

        // VERİTABANI KOMUTLARI
        SqlConnection Baglanti = new SqlConnection("Data Source=DESKTOP-R6M9ALH\\SQLEXPRESS;Initial Catalog=Tez_Kontrol;Integrated Security=True");
        SqlCommand Komut;
        SqlDataReader Reading;
        SqlDataAdapter Adaptering;
        DataTable Kayıt_Tablomuz = new DataTable();

        public Frm_Üye_Ekle()
        {
            InitializeComponent();
        }

        private void Frm_Üye_Ekle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'tez_KontrolDataSet1.Login_Data' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.login_DataTableAdapter.Fill(this.tez_KontrolDataSet1.Login_Data);

        }
        private void Tablola()
        {
            Kayıt_Tablomuz.Clear();

            Baglanti.Open();
            Komut = new SqlCommand("SELECT Adi , Soyadi , e_mail ,K_Adi , Sifre FROM Login_Data", Baglanti);
            Adaptering = new SqlDataAdapter(Komut);
            Adaptering.Fill(Kayıt_Tablomuz);
            dataGridView1.DataSource = Kayıt_Tablomuz;
            Baglanti.Close();
        }

        private void button_Üyeyi_Ekle_Click(object sender, EventArgs e)
        {
            if (textBox_Adi.Text == "" && textBox_Soyadi.Text == "" && textBox_e_maili.Text == "" && textBox_K_Adi.Text == "" && textBox_Parola.Text == "" && textBox_Parola_Tekrar.Text == "")
            {
                MessageBox.Show("BİLGİLERİN TAMAMI BOŞ GÖRÜNÜYOR BOŞ ÜYE KAYDI YAPILAMAZ ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
           
           else if (textBox_Adi.Text == "" )
            {
 
                MessageBox.Show("ADINIZ Alanı Boş Geçilemez Bir Alandır Lütfen Bu Alanı Doldurup Tekrar Deneyiniz ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if( textBox_Soyadi.Text == "" )
            {
                MessageBox.Show("SOYADINIZ Alanı Boş Geçilemez Bir Alandır Lütfen Bu Alanı Doldurup Tekrar Deneyiniz ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ( textBox_e_maili.Text == "" )
            {
                MessageBox.Show("E MAİLİNİZ Alanı Boş Geçilemez Bir Alandır Lütfen Bu Alanı Doldurup Tekrar Deneyiniz ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ( textBox_K_Adi.Text == "" )
            {
                MessageBox.Show("K_ADINIZ Alanı Boş Geçilemez Bir Alandır Lütfen Bu Alanı Doldurup Tekrar Deneyiniz ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ( textBox_Parola.Text == "")
            {
                MessageBox.Show("PAROLANIZ Alanı Boş Geçilemez Bir Alandır Lütfen Bu Alanı Doldurup Tekrar Deneyiniz ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ( textBox_Parola_Tekrar.Text == "")
            {
                MessageBox.Show("PAROLANIZ TEKRAR Alanı Boş Geçilemez Bir Alandır Lütfen Bu Alanı Doldurup Tekrar Deneyiniz ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.Compare(textBox_Parola.Text , textBox_Parola_Tekrar.Text)!=0)
            {
                MessageBox.Show("GİRDİĞİNİZ PAROLALAR UYUŞMUYOR LÜTFEN İKİ PAROLA ALANINIDA DOĞRU VE EŞLEŞECEK ŞEKİLDE DOLDURUP TEKRAR DENEYİNİZ  ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Baglanti.Open();
                Komut = new SqlCommand("INSERT INTO Login_Data (Adi , Soyadi , e_mail ,K_Adi , Sifre) VALUES ('" + textBox_Adi.Text + "','" + textBox_Soyadi.Text + "','" + textBox_e_maili.Text + "','" + textBox_K_Adi.Text + "','" + textBox_Parola.Text + "')", Baglanti);
                Komut.ExecuteNonQuery();
                Baglanti.Close();
                Tablola();
            }
        }

        private void button_Üye_Sil_Click(object sender, EventArgs e)
        {
            if (textBox_Silinen_Mail.Text == "")
            {
                // TEXTBOXLAR BOŞ BIRAKILIRSA ÇIKAN UYARI
                MessageBox.Show("Lütfen Hangi Üyeyi Silmek İstiyorsanız O Üyenin E Mail Adresini Aşağıda Bulunan SİLMEK İSTEDİĞİNİZ E MAİL Kutucuğuna Giriniz Aksi Halde Üye Silme İşleminiz Gerçekleştirilemez ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                Baglanti.Open();
                Komut = new SqlCommand("DELETE FROM Login_Data WHERE e_mail = '" + textBox_Silinen_Mail.Text + "'", Baglanti);
                Komut.ExecuteNonQuery();
                Baglanti.Close();
                Tablola();
            }
        }

        private void button_Üye_Güncelleme_Click(object sender, EventArgs e)
        {
            if (textBox_Adi.Text == "" && textBox_Soyadi.Text == "" && textBox_e_maili.Text == "" && textBox_K_Adi.Text == "" && textBox_Parola.Text == "" && textBox_Parola_Tekrar.Text == "")
            {
                MessageBox.Show("BİLGİLERİN TAMAMI BOŞ GÖRÜNÜYOR BOŞ ÜYE GÜNCELLEMESİ YAPILAMAZ ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            else if (textBox_Adi.Text == "")
            {

                MessageBox.Show("Güncelleme İşleminde ADINIZ Alanı Boş Geçilemez Bir Alandır Lütfen Bu Alanı Doldurup Tekrar Deneyiniz ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox_Soyadi.Text == "")
            {
                MessageBox.Show("Güncelleme İşleminde SOYADINIZ Alanı Boş Geçilemez Bir Alandır Lütfen Bu Alanı Doldurup Tekrar Deneyiniz ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox_e_maili.Text == "")
            {
                MessageBox.Show("Güncelleme İşleminde E MAİLİNİZ Alanı Boş Geçilemez Bir Alandır Lütfen Bu Alanı Doldurup Tekrar Deneyiniz ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox_K_Adi.Text == "")
            {
                MessageBox.Show("Güncelleme İşleminde K_ADINIZ Alanı Boş Geçilemez Bir Alandır Lütfen Bu Alanı Doldurup Tekrar Deneyiniz ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox_Parola.Text == "")
            {
                MessageBox.Show("Güncelleme İşleminde PAROLANIZ Alanı Boş Geçilemez Bir Alandır Lütfen Bu Alanı Doldurup Tekrar Deneyiniz ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox_Parola_Tekrar.Text == "")
            {
                MessageBox.Show("Güncelleme İşleminde PAROLANIZ TEKRAR Alanı Boş Geçilemez Bir Alandır Lütfen Bu Alanı Doldurup Tekrar Deneyiniz ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.Compare(textBox_Parola.Text, textBox_Parola_Tekrar.Text) != 0)
            {
                MessageBox.Show("GÜNCELLEME İŞLEMİNDE GİRDİĞİNİZ PAROLALAR UYUŞMUYOR  GÜNCELLEME YAPABİLMEK İÇİN LÜTFEN İKİ PAROLA ALANINIDA DOĞRU VE EŞLEŞECEK ŞEKİLDE DOLDURUP TEKRAR DENEYİNİZ  ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox_Güncellenen_Mail.Text == "")
            {
                // TEXTBOXLAR BOŞ BIRAKILIRSA ÇIKAN UYARI
                MessageBox.Show("Lütfen Hangi Üyeyi Güncellemek İstiyorsanız O Üyenin E Mail Adresini Aşağıda Bulunan GÜNCELLEMEK İSTEDİĞİNİZ E MAİL Kutucuğuna Giriniz Aksi Halde Üye Güncelleme İşleminiz Gerçekleştirilemez ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                Baglanti.Open();
                Komut = new SqlCommand("UPDATE Login_Data SET Adi='" + textBox_Adi.Text + "', Soyadi='" + textBox_Soyadi.Text + "', e_mail='" + textBox_e_maili.Text + "' , K_Adi='" + textBox_K_Adi.Text + "', Sifre='" + textBox_Parola.Text + "'WHERE e_mail='" + textBox_Güncellenen_Mail.Text + "'", Baglanti);
                Komut.ExecuteNonQuery();
                Baglanti.Close();
                Tablola();
            }
        }

        private void button_Cıkıs_Yap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Üyeler Üye_Giris = new Frm_Üyeler();
            Üye_Giris.ShowDialog();
        }
    }
}
