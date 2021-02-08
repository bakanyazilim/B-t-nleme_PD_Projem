
namespace Tez_Kontrol_Sistemi_Firat
{
    partial class Frm_Login
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripComboBox_Kullanım = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBox_Unuttum = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBox_Yardım = new System.Windows.Forms.ToolStripComboBox();
            this.ToolStripMenuItem_Üye_İslem = new System.Windows.Forms.ToolStripMenuItem();
            this.Lbl_Üst_Bilgi = new System.Windows.Forms.Label();
            this.Lbl_Kullanıcı_Adı = new System.Windows.Forms.Label();
            this.Lbl_Parola = new System.Windows.Forms.Label();
            this.textBox_Kullanıcı_Adi = new System.Windows.Forms.TextBox();
            this.textBox_Parola = new System.Windows.Forms.TextBox();
            this.button_Üye_Ol = new System.Windows.Forms.Button();
            this.button_Sifre_Unuttum = new System.Windows.Forms.Button();
            this.button_Giris = new System.Windows.Forms.Button();
            this.Lbl_Alt_Bilgi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox_Kullanım,
            this.toolStripComboBox_Unuttum,
            this.toolStripComboBox_Yardım,
            this.ToolStripMenuItem_Üye_İslem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(923, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripComboBox_Kullanım
            // 
            this.toolStripComboBox_Kullanım.BackColor = System.Drawing.Color.Yellow;
            this.toolStripComboBox_Kullanım.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.toolStripComboBox_Kullanım.Name = "toolStripComboBox_Kullanım";
            this.toolStripComboBox_Kullanım.Size = new System.Drawing.Size(121, 28);
            this.toolStripComboBox_Kullanım.Text = "KULLANIM ?";
            this.toolStripComboBox_Kullanım.Click += new System.EventHandler(this.toolStripComboBox_Kullanım_Click);
            // 
            // toolStripComboBox_Unuttum
            // 
            this.toolStripComboBox_Unuttum.BackColor = System.Drawing.Color.Tan;
            this.toolStripComboBox_Unuttum.Name = "toolStripComboBox_Unuttum";
            this.toolStripComboBox_Unuttum.Size = new System.Drawing.Size(121, 28);
            this.toolStripComboBox_Unuttum.Text = "Sifre Unutmak";
            this.toolStripComboBox_Unuttum.Click += new System.EventHandler(this.toolStripComboBox_Unuttum_Click);
            // 
            // toolStripComboBox_Yardım
            // 
            this.toolStripComboBox_Yardım.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.toolStripComboBox_Yardım.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripComboBox_Yardım.ForeColor = System.Drawing.Color.Red;
            this.toolStripComboBox_Yardım.Name = "toolStripComboBox_Yardım";
            this.toolStripComboBox_Yardım.Size = new System.Drawing.Size(121, 28);
            this.toolStripComboBox_Yardım.Text = "YARDIM";
            this.toolStripComboBox_Yardım.Click += new System.EventHandler(this.toolStripComboBox_Yardım_Click);
            // 
            // ToolStripMenuItem_Üye_İslem
            // 
            this.ToolStripMenuItem_Üye_İslem.BackColor = System.Drawing.SystemColors.Control;
            this.ToolStripMenuItem_Üye_İslem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ToolStripMenuItem_Üye_İslem.ForeColor = System.Drawing.Color.OrangeRed;
            this.ToolStripMenuItem_Üye_İslem.Name = "ToolStripMenuItem_Üye_İslem";
            this.ToolStripMenuItem_Üye_İslem.Size = new System.Drawing.Size(119, 28);
            this.ToolStripMenuItem_Üye_İslem.Text = "Üye İşlemleri ?";
            this.ToolStripMenuItem_Üye_İslem.Click += new System.EventHandler(this.ToolStripMenuItem_Üye_İslem_Click);
            // 
            // Lbl_Üst_Bilgi
            // 
            this.Lbl_Üst_Bilgi.AutoSize = true;
            this.Lbl_Üst_Bilgi.BackColor = System.Drawing.Color.Aqua;
            this.Lbl_Üst_Bilgi.Font = new System.Drawing.Font("Montserrat", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Üst_Bilgi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Lbl_Üst_Bilgi.Location = new System.Drawing.Point(171, 43);
            this.Lbl_Üst_Bilgi.Name = "Lbl_Üst_Bilgi";
            this.Lbl_Üst_Bilgi.Size = new System.Drawing.Size(646, 37);
            this.Lbl_Üst_Bilgi.TabIndex = 1;
            this.Lbl_Üst_Bilgi.Text = "FIRAT ÜNİVERSİTESİ KONTROL SİSTEMİ";
            // 
            // Lbl_Kullanıcı_Adı
            // 
            this.Lbl_Kullanıcı_Adı.AutoSize = true;
            this.Lbl_Kullanıcı_Adı.BackColor = System.Drawing.Color.Gray;
            this.Lbl_Kullanıcı_Adı.Font = new System.Drawing.Font("Oswald", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_Kullanıcı_Adı.ForeColor = System.Drawing.Color.Lime;
            this.Lbl_Kullanıcı_Adı.Location = new System.Drawing.Point(170, 124);
            this.Lbl_Kullanıcı_Adı.Name = "Lbl_Kullanıcı_Adı";
            this.Lbl_Kullanıcı_Adı.Size = new System.Drawing.Size(246, 45);
            this.Lbl_Kullanıcı_Adı.TabIndex = 2;
            this.Lbl_Kullanıcı_Adı.Text = "K. Adınızı Giriniz :";
            // 
            // Lbl_Parola
            // 
            this.Lbl_Parola.AutoSize = true;
            this.Lbl_Parola.BackColor = System.Drawing.Color.Gray;
            this.Lbl_Parola.Font = new System.Drawing.Font("Oswald", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_Parola.ForeColor = System.Drawing.Color.Lime;
            this.Lbl_Parola.Location = new System.Drawing.Point(170, 259);
            this.Lbl_Parola.Name = "Lbl_Parola";
            this.Lbl_Parola.Size = new System.Drawing.Size(236, 45);
            this.Lbl_Parola.TabIndex = 2;
            this.Lbl_Parola.Text = "Sifrenizi Giriniz :";
            // 
            // textBox_Kullanıcı_Adi
            // 
            this.textBox_Kullanıcı_Adi.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_Kullanıcı_Adi.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Kullanıcı_Adi.Location = new System.Drawing.Point(422, 124);
            this.textBox_Kullanıcı_Adi.Name = "textBox_Kullanıcı_Adi";
            this.textBox_Kullanıcı_Adi.Size = new System.Drawing.Size(355, 46);
            this.textBox_Kullanıcı_Adi.TabIndex = 3;
            // 
            // textBox_Parola
            // 
            this.textBox_Parola.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_Parola.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Parola.Location = new System.Drawing.Point(422, 258);
            this.textBox_Parola.Name = "textBox_Parola";
            this.textBox_Parola.PasswordChar = '.';
            this.textBox_Parola.Size = new System.Drawing.Size(355, 46);
            this.textBox_Parola.TabIndex = 3;
            // 
            // button_Üye_Ol
            // 
            this.button_Üye_Ol.BackColor = System.Drawing.Color.Goldenrod;
            this.button_Üye_Ol.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Üye_Ol.ForeColor = System.Drawing.Color.Aqua;
            this.button_Üye_Ol.Location = new System.Drawing.Point(680, 317);
            this.button_Üye_Ol.Name = "button_Üye_Ol";
            this.button_Üye_Ol.Size = new System.Drawing.Size(97, 67);
            this.button_Üye_Ol.TabIndex = 4;
            this.button_Üye_Ol.Text = "ÜYE OL";
            this.button_Üye_Ol.UseVisualStyleBackColor = false;
            this.button_Üye_Ol.Click += new System.EventHandler(this.button_Üye_Ol_Click);
            // 
            // button_Sifre_Unuttum
            // 
            this.button_Sifre_Unuttum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Sifre_Unuttum.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Sifre_Unuttum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_Sifre_Unuttum.Location = new System.Drawing.Point(475, 317);
            this.button_Sifre_Unuttum.Name = "button_Sifre_Unuttum";
            this.button_Sifre_Unuttum.Size = new System.Drawing.Size(97, 67);
            this.button_Sifre_Unuttum.TabIndex = 4;
            this.button_Sifre_Unuttum.Text = "Şifrem Kayıp";
            this.button_Sifre_Unuttum.UseVisualStyleBackColor = false;
            this.button_Sifre_Unuttum.Click += new System.EventHandler(this.button_Sifre_Unuttum_Click);
            // 
            // button_Giris
            // 
            this.button_Giris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_Giris.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Giris.ForeColor = System.Drawing.Color.SpringGreen;
            this.button_Giris.Location = new System.Drawing.Point(270, 317);
            this.button_Giris.Name = "button_Giris";
            this.button_Giris.Size = new System.Drawing.Size(97, 67);
            this.button_Giris.TabIndex = 4;
            this.button_Giris.Text = "Giriş Yap";
            this.button_Giris.UseVisualStyleBackColor = false;
            this.button_Giris.Click += new System.EventHandler(this.button_Giris_Click);
            // 
            // Lbl_Alt_Bilgi
            // 
            this.Lbl_Alt_Bilgi.AutoSize = true;
            this.Lbl_Alt_Bilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_Alt_Bilgi.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Alt_Bilgi.Location = new System.Drawing.Point(8, 397);
            this.Lbl_Alt_Bilgi.Name = "Lbl_Alt_Bilgi";
            this.Lbl_Alt_Bilgi.Size = new System.Drawing.Size(799, 20);
            this.Lbl_Alt_Bilgi.TabIndex = 5;
            this.Lbl_Alt_Bilgi.Text = "Lütfen Sistem Hakkında Herhangi Bir Sorun Yaşamanız Durumunda Üstteki Bilgi Kutuc" +
    "uklarına Göz Atınız";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 227);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(152, 109);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(923, 443);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Lbl_Alt_Bilgi);
            this.Controls.Add(this.button_Giris);
            this.Controls.Add(this.button_Sifre_Unuttum);
            this.Controls.Add(this.button_Üye_Ol);
            this.Controls.Add(this.textBox_Parola);
            this.Controls.Add(this.textBox_Kullanıcı_Adi);
            this.Controls.Add(this.Lbl_Parola);
            this.Controls.Add(this.Lbl_Kullanıcı_Adı);
            this.Controls.Add(this.Lbl_Üst_Bilgi);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMİN GİRİŞ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label Lbl_Üst_Bilgi;
        private System.Windows.Forms.Label Lbl_Kullanıcı_Adı;
        private System.Windows.Forms.Label Lbl_Parola;
        private System.Windows.Forms.TextBox textBox_Kullanıcı_Adi;
        private System.Windows.Forms.TextBox textBox_Parola;
        private System.Windows.Forms.Button button_Üye_Ol;
        private System.Windows.Forms.Button button_Sifre_Unuttum;
        private System.Windows.Forms.Button button_Giris;
        private System.Windows.Forms.Label Lbl_Alt_Bilgi;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_Yardım;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_Kullanım;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_Unuttum;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Üye_İslem;
    }
}

