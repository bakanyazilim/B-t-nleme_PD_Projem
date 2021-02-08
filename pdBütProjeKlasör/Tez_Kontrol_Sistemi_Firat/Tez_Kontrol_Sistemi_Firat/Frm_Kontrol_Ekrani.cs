using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Office.Interop.Word;
using System.IO;


namespace Tez_Kontrol_Sistemi_Firat
{
    public partial class Frm_Kontrol_Ekrani : Form
    {
        public Frm_Kontrol_Ekrani()
        {
            InitializeComponent();
        }

        private void nasılKullanılırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kontrol Etmek İstediğiniz Tez Dosyası Bilgisayarınızda kayıtlı Olmak Zorundadır Dosya Bilgisayarınızda Kayıtlı İse " +
                "Alt tarafta Bulunan 'DOSYA SEÇİMİ YAP' Butonuna Tıklayınca Açılan Dosya Seçim Ekranında Bilgisayarınızdaki  Tüm Word Türündeki Dosyalar Görünecektir " +
                "Kontrol Etmek İstediğiniz Tez Dosyasını Seçiniz. Bu İşlemden Sonra Sistemimiz Tezinizi  Belli Kurallar Çerçevesinde Kontrol Edecektir " +
                "Dosyanızın Boyutuna Göre Beklemeniz Uzayabilir " +
                "Tarama İşleminden Sonra Uyarı Mesajı Verilecektir. Uyarı Mesajından Önce  Sistemden Ayrılmamanız En Doğru Sonuç İçin Gereklidir ", "Nasıl Kullanılıyor?",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void neleriKontrolEdebilirimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dosya Türünüz Word Dosyası Formatında  Yani '.docx' Uzantılı Olmak Zorundadır. Aksi Halde 'DOSYA SEÇİMİ YAP' Butonundaki Dosya Yükleme Alanında Dosyanızı Göremez VE İşlemini Gerçekleştiremezsiniz "
               , "Dosya Türüm Ne Olmalı ", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void dosyaSeçimButonuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("'DOSYA SEÇİMİ YAP' Butonu Dosya Yükleme Alanında Word Dosyası Formatındaki  Dosyanızı Görmek  VE  Sisteme Eklemek Üzere Tasarlanmıştır Eğer Dosyanız Word Dosya Formatında Değil İse İşlemini Gerçekleştiremezsiniz "
               , "Dosya Seçim Tuşu Ne İş Yapıyor  ", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void bulunanHatalarNeredeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("'DOSYA SEÇİMİ YAP' Butonu İle  Sisteme Dosyanızı Ekledikten Sonra En Geç 1 Dakika İçinde Aşağıda Bulunan Kutu İçerine Hatalarınız Yazdırılmış Olacaktır "
               , "Hataları Nerede Görebilirim  ", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void button_Dosya_Secimi_Click(object sender, EventArgs e)
        {
            
            // KULLANICININ SİSTEME DOSYAYI TANITMASI

            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Word Dosyası |*.docx";
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            file.Title = "Word Dosyası Seçiniz...";

            if (file.ShowDialog() == DialogResult.OK)
            {
                string dosyayolu = file.FileName;
                string dosya_adi = file.SafeFileName;

                {
                    // SİSTEMİN DOSYAYI KONTROL ETMESİ SIRASINDA VERİLEN MESAJ

                    Lbl_Bilgi.Text = dosya_adi + " Dosyası Kontrol Ediliyor. Lütfen Bekleyiniz...";

                    richTextBox1.Clear();

                    Microsoft.Office.Interop.Word.Application wordObject = new Microsoft.Office.Interop.Word.Application();

                    object nullobject = System.Reflection.Missing.Value;

                    Microsoft.Office.Interop.Word.Document docs = wordObject.Documents.Open(dosyayolu);

                    docs.ActiveWindow.Selection.WholeStory();
                    docs.ActiveWindow.Selection.Copy();
                    IDataObject data = Clipboard.GetDataObject();

                    string satir = "";

                    int i = 1;

                    Document TEZ = new Document();
                    TEZ = docs;


                    foreach (Microsoft.Office.Interop.Word.Paragraph objParagraph in docs.Paragraphs)
                    {
                        // FONT ÖZELİĞİ İÇİN

                        Microsoft.Office.Interop.Word.Font s = docs.Paragraphs[i].Range.Font;

                        // BAZI KRİTER KONTROLLERİ 

                        if (docs.Paragraphs[i].Range.Text == "ÖNSÖZ")
                        {
                            richTextBox1.Text += "\n ÖNSÖZ MEVCUTTUR " + i;
                        }
                        else if (docs.Paragraphs[i].Range.ToString() == "İÇİNDEKİLER")
                        {
                            richTextBox1.Text += "\n İÇİNDEKİLER LİSTESİ MEVCUTTUR" + i;
                        }
                        else if (docs.Paragraphs[i].Range.ToString() == "ÖZET")
                        {
                            richTextBox1.Text += "\n ÖZET METNİ MEVCUTTUR. " + i;
                        }
                        else if (docs.Paragraphs[i].Range.ToString() == "ABSTRACT")
                        {
                            richTextBox1.Text += "\n İNGİLİZCE ÖZET METNİ MEVCUTTUR. " + i;
                        }
                        else if (docs.Paragraphs[i].Range.ToString() == "ŞEKİLLER LİSTESİ")
                        {
                            richTextBox1.Text += "\n ŞEKİLLER LİSTESİ MEVCUTTUR. " + i;
                        }
                        else if (docs.Paragraphs[i].Range.ToString() == "TABLOLAR LİSTESİ")
                        {
                            richTextBox1.Text += "\n TABLOLAR LİSTESİ MEVCUTTUR. " + i;
                        }
                        else if (docs.Paragraphs[i].Range.ToString() == "EKLER LİSTESİ")
                        {
                            richTextBox1.Text += "\n EKLER LİSTESİ MEVCUTTUR. " + i;
                        }
                        else if (docs.Paragraphs[i].Range.ToString() == "SİMGELER VE KISALTMALAR")
                        {
                            richTextBox1.Text += "\n SİMGELER VE KISALTMLAR MEVCUTTUR." + i;
                        }

                        if (s.Size == 12F)
                        {

                            // YAZI FONTU 12 İSE KONTROL EDİLECEKLER

                            if (s.Position.ToString() != "wdVerticalAlignmentLeft")
                            {
                                // DÜZEN KONTROLÜ
                                richTextBox1.Text += "\n ara başlık sola yaslı değil satır :" + i;
                            }
                            if (s.ColorIndex.ToString() != "wdBlack")
                            {
                                // YAZI RENGİ KONTROLÜ
                                richTextBox1.Text += "\n yazı rengi yanlış satır:" + i;
                            }
                            if (s.Name.ToString() != "Times New Roman")
                            {
                                // YAZI TÜR KONTROLÜ
                                richTextBox1.Text += "\n yazı stili yanlış satır:" + i;
                            }
                        }
                        else
                        if (s.Size == 16F)
                        {
                            // YAZI FONTU 16 İSE KONTROL EDİLECEKLER

                            if (s.Position.ToString() != "WdVerticalAlignmentCenter")
                            {
                                // DÜZEN KONTROLÜ
                                richTextBox1.Text += "\n ana başlık iki yana yaslı değil satır:  " + i;
                            }
                            if (s.ColorIndex.ToString() != "wdBlack")
                            {
                                // YAZI RENGİ KONTROLÜ
                                richTextBox1.Text += "\n yazı rengi yanlış satır:" + i;
                            }
                            if (s.Name.ToString() != "Times New Roman")
                            {
                                // YAZI TÜR KONTROLÜ
                                richTextBox1.Text += "\n yazı stili yanlış satır:" + i;
                            }

                        }
                        else
                        if (s.Size == 11F)
                        {
                            // YAZI FONTU 11 İSE KONTROL EDİLECEKLER

                            if (s.Position.ToString() != "WdVerticalAlignmentCenter")
                            {
                                // DÜZEN KONTROLÜ
                                richTextBox1.Text += "\n ana başlık iki yana yaslı değil satır:  " + i;
                            }
                            if (s.ColorIndex.ToString() != "wdBlack")
                            {
                                // YAZI RENGİ KONTROLÜ
                                richTextBox1.Text += "\n yazı rengi yanlış satır:" + i;
                            }
                            if (s.Name.ToString() != "Times New Roman")
                            {
                                // YAZI TÜR KONTROLÜ
                                richTextBox1.Text += "\n yazı stili yanlış satır:" + i;
                            }

                        }
                        // YAZI FONT KONTROLLERİ YAPILDI

                        else
                        {
                            // FARKLI BİR FONT OLMASI DURUMUNDAKİ KONTROL BLOĞU 

                            richTextBox1.Text += "\n yazı boyutu 11 punto değil satır:" + i;

                            if (s.Name.ToString() != "Times New Roman")
                            {
                                richTextBox1.Text += "\n yazı stili yanlış satır:" + i;
                            }
                            if (s.ColorIndex.ToString() != "wdBlack")
                            {
                                richTextBox1.Text += "\n yazı rengi yanlış satır:" + i;
                            }
                        }

                        // SATIR NUMARASININ BİR SONRAKİ SATIRA GEÇMESİ İÇİN KULLANDIĞIMIZ İFADE

                        i++;
                    }

                    i = 1;

                    //*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-**-*-*
                    // ÜSTTEN BOŞLUĞUN DOĞRULUĞU KONTROLÜ
                    if (TEZ.PageSetup.TopMargin.ToString() != "85,05")
                    {
                        richTextBox1.Text += "\n üst boşluk yanlış:";
                    }

                    // ALTTAN BOŞLUĞUN DOĞRULUĞU KONTROLÜ
                    if (TEZ.PageSetup.BottomMargin.ToString() != "70,9")
                    {
                        richTextBox1.Text += "\n alt boşluk yanlış:";
                    }
                    //*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-**-*-*

                    //+*+*+*+*+*+**++**+*+*+*+*+*+*+*+*+*+*+*+*+*++*+**+*+*+

                    //SAĞ BOŞLUĞUN DOĞRULUĞU KONTROLÜ
                    if (TEZ.PageSetup.RightMargin.ToString() != "70,9")
                    {
                        richTextBox1.Text += "\n sağ boşluk yanlış:";
                    }
                    //SOL BOŞLUĞUN DOĞRULUĞU KONTROLÜ
                    if (TEZ.PageSetup.LeftMargin.ToString() != "92,15")
                    {
                        richTextBox1.Text += "\n sol boşluk yanlış:";
                    }

                    //+*+*+*+*+*+**++**+*+*+*+*+*+*+*+*+*+*+*+*+*++*+**+*+*+

                    // PARAGRAFLARIN KONTROLÜ
                    if (TEZ.Paragraphs.Alignment != WdParagraphAlignment.wdAlignParagraphCenter)
                    {
                        richTextBox1.Text += "\n iki yana yaslı değil";

                        // KONTROL BİTTİKTEN SONRA KULLANICIYA VERİLECEK MESAJ
                        Lbl_Bilgi.Text = dosya_adi + " Dosyası Kontrol Edildi. Ayrıntılar Aşağıdaki Kısımdadır.";
                    }

                    // TARAMA TAMAMEN BİTTİKTEN SONRA KULLANICIYA VERİLECEK MESAJ
                    MessageBox.Show("Tarama İşlemi Başarılı Bir Şekilde Tamamlandı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    docs.Close(ref nullobject, ref nullobject, ref nullobject);

                git:
                    return;
                    

                }
            }
        }

        private void button_Cıkıs_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Login giris = new Frm_Login();
            giris.ShowDialog();
        }
    }
}
