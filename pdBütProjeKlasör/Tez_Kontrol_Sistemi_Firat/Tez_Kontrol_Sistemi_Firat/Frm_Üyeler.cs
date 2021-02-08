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
    public partial class Frm_Üyeler : Form
    {
        // VERİTABANI KOMUTLARI
        SqlConnection Baglanti = new SqlConnection("Data Source=DESKTOP-R6M9ALH\\SQLEXPRESS;Initial Catalog=Tez_Kontrol;Integrated Security=True");
        SqlCommand Komut;
        SqlDataReader Reading;
        SqlDataAdapter Adaptering;
        DataTable Kayıt_Tablomuz = new DataTable();
        public Frm_Üyeler()
        {
            InitializeComponent();
        }

        private void Frm_Üyeler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'tez_KontrolDataSet1.Login_Data' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.login_DataTableAdapter.Fill(this.tez_KontrolDataSet1.Login_Data);

        }

        private void button_Üye_Ekle_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Üye_Ekle İslem = new Frm_Üye_Ekle();
            İslem.ShowDialog();
        }

        private void button_Göster_Click(object sender, EventArgs e)
        {

            Tablola();

           
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

        private void button_Cıkıs_Yap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Login giris = new Frm_Login();
            giris.ShowDialog();
        }
    }
}
