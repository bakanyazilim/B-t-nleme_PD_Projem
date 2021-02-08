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
using System.Net.Mail;
using System.Net;
using System.Security;

namespace Tez_Kontrol_Sistemi_Firat
{
    public partial class Frm_Parola_Hatırlatma : Form
    {
        SqlConnection Baglanti = new SqlConnection("Data Source=DESKTOP-R6M9ALH\\SQLEXPRESS;Initial Catalog=Tez_Kontrol;Integrated Security=True");
        SqlCommand Komut;
        SqlDataReader Reading;
        SqlDataAdapter Adaptering;

        public bool Gonder(string konu, string icerik)
        {
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("beratbakan11@gmail.com");//buraya kendi gmail hesabınız
            //
            ePosta.To.Add(textBox_Mail.Text);//bura şifre unutanın maili textboxdan çekdiniz.
            ;

            ePosta.Subject = konu; //butonda veri tabanı çekdikden sonra aldımız değer konu değeri
            //
            ePosta.Body = icerik;  // buda şifremiz
            //
            SmtpClient smtp = new SmtpClient();
            //
            smtp.Credentials = new System.Net.NetworkCredential("Kontol.Sistemi.Firat@gmail.com", "deha_Firat");
            //kendi gmail hesabiniz var şifresi
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            object userState = ePosta;
            bool kontrol = true;
            try
            {
                smtp.SendAsync(ePosta, (object)ePosta);
            }
            catch (SmtpException ex)
            {
                kontrol = false;
                System.Windows.Forms.MessageBox.Show(ex.Message, "Mail Gönderme Hatasi");
            }
            return kontrol;

        }
        public Frm_Parola_Hatırlatma()
        {
            InitializeComponent();
        }
        //string sifre;
        private void button_Posta_At_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            string sifre= "Select Sifre FROM Login_Data ";
            string E_posta = textBox_Mail.Text;
            string MailAdres = textBox_Kulanici_Adi.Text;
            Adaptering = new SqlDataAdapter("SELECT e_mail,Sifre,K_Adi FROM Login_Data", Baglanti);
            Komut = new SqlCommand(MailAdres+E_posta);
            Komut.CommandText = "SELECT e_mail, Sifre,K_Adi FROM Login_Data WHERE e_mail='" + textBox_Mail.Text+"'";
            Komut.Connection = Baglanti;
            Reading = Komut.ExecuteReader();

            if (Baglanti.State == ConnectionState.Closed) //eğer bağlantı kapalıysa
            {
                Baglanti.Open(); //bağlantıyı aç
            }

            SqlCommand com = new SqlCommand("SELECT K_Adi, e_mail,Sifre FROM Login_Data WHERE K_Adi='" + textBox_Kulanici_Adi.Text.ToString() +
                "'and e_mail='" + textBox_Mail.Text.ToString() + "'", Baglanti);
            //burada veritabanina kodlayarak yazdımız şifrelerin kodlarını karşılaştırdık
            Baglanti.Close();
            Baglanti.Open();
            SqlDataReader oku = com.ExecuteReader();
            if (oku.Read())
            {
                //burada verdiği tc ve mail doğruysa gireceği için şifreyi veritabanından çekip gönder fonksiyonunu kullanarak göndereceğiz

                sifre = oku["Sifre"].ToString();
                //veritabanından çekdik            
                MessageBox.Show("Girmiş Oldunuz Bilgiler Uyuşuyor Şifreniz Mail adresinize yollanıyor");
                Gonder("Unutmuş Olduğunuz Şifreniz Ektedir", sifre);
                //gönder paremetresi ile içeriğe 2 string değer yolladık biri mesajımız öbürü şifresi
                Baglanti.Close();
            }
            else
            {
                MessageBox.Show("Bilgileriniz Uyuşmadı");
            }
            Baglanti.Close();
        }

        private void button_İptal_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            Frm_Login Giris_Sayfa = new Frm_Login();
            Giris_Sayfa.ShowDialog();
        }
    }
}

         
    

