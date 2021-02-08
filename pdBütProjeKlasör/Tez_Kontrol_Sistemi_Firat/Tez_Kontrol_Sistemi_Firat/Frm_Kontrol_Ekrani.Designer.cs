
namespace Tez_Kontrol_Sistemi_Firat
{
    partial class Frm_Kontrol_Ekrani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button_Dosya_Secimi = new System.Windows.Forms.Button();
            this.button_Cıkıs = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nasılKullanılırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neleriKontrolEdebilirimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaSeçimButonuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bulunanHatalarNeredeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Lbl_Bilgi = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.BurlyWood;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.richTextBox1.Location = new System.Drawing.Point(12, 173);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1284, 368);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // button_Dosya_Secimi
            // 
            this.button_Dosya_Secimi.BackColor = System.Drawing.Color.Aqua;
            this.button_Dosya_Secimi.Font = new System.Drawing.Font("Ravie", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Dosya_Secimi.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_Dosya_Secimi.Location = new System.Drawing.Point(758, 57);
            this.button_Dosya_Secimi.Name = "button_Dosya_Secimi";
            this.button_Dosya_Secimi.Size = new System.Drawing.Size(244, 97);
            this.button_Dosya_Secimi.TabIndex = 1;
            this.button_Dosya_Secimi.Text = "DOSYA SEÇİMİ YAP";
            this.button_Dosya_Secimi.UseVisualStyleBackColor = false;
            this.button_Dosya_Secimi.Click += new System.EventHandler(this.button_Dosya_Secimi_Click);
            // 
            // button_Cıkıs
            // 
            this.button_Cıkıs.BackColor = System.Drawing.Color.Yellow;
            this.button_Cıkıs.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cıkıs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_Cıkıs.Location = new System.Drawing.Point(1018, 57);
            this.button_Cıkıs.Name = "button_Cıkıs";
            this.button_Cıkıs.Size = new System.Drawing.Size(244, 97);
            this.button_Cıkıs.TabIndex = 1;
            this.button_Cıkıs.Text = "ÇIKIŞ YAP";
            this.button_Cıkıs.UseVisualStyleBackColor = false;
            this.button_Cıkıs.Click += new System.EventHandler(this.button_Cıkıs_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nasılKullanılırToolStripMenuItem,
            this.neleriKontrolEdebilirimToolStripMenuItem,
            this.dosyaSeçimButonuToolStripMenuItem,
            this.bulunanHatalarNeredeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1308, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nasılKullanılırToolStripMenuItem
            // 
            this.nasılKullanılırToolStripMenuItem.Name = "nasılKullanılırToolStripMenuItem";
            this.nasılKullanılırToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.nasılKullanılırToolStripMenuItem.Text = "Nasıl Kullanılır ?";
            this.nasılKullanılırToolStripMenuItem.Click += new System.EventHandler(this.nasılKullanılırToolStripMenuItem_Click);
            // 
            // neleriKontrolEdebilirimToolStripMenuItem
            // 
            this.neleriKontrolEdebilirimToolStripMenuItem.Name = "neleriKontrolEdebilirimToolStripMenuItem";
            this.neleriKontrolEdebilirimToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.neleriKontrolEdebilirimToolStripMenuItem.Text = "Neleri Kontrol Edebilirim ?";
            this.neleriKontrolEdebilirimToolStripMenuItem.Click += new System.EventHandler(this.neleriKontrolEdebilirimToolStripMenuItem_Click);
            // 
            // dosyaSeçimButonuToolStripMenuItem
            // 
            this.dosyaSeçimButonuToolStripMenuItem.Name = "dosyaSeçimButonuToolStripMenuItem";
            this.dosyaSeçimButonuToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.dosyaSeçimButonuToolStripMenuItem.Text = "Dosya Seçim Butonu ?";
            this.dosyaSeçimButonuToolStripMenuItem.Click += new System.EventHandler(this.dosyaSeçimButonuToolStripMenuItem_Click);
            // 
            // bulunanHatalarNeredeToolStripMenuItem
            // 
            this.bulunanHatalarNeredeToolStripMenuItem.Name = "bulunanHatalarNeredeToolStripMenuItem";
            this.bulunanHatalarNeredeToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.bulunanHatalarNeredeToolStripMenuItem.Text = "Bulunan Hatalar Nerede ?";
            this.bulunanHatalarNeredeToolStripMenuItem.Click += new System.EventHandler(this.bulunanHatalarNeredeToolStripMenuItem_Click);
            // 
            // Lbl_Bilgi
            // 
            this.Lbl_Bilgi.AutoSize = true;
            this.Lbl_Bilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_Bilgi.Location = new System.Drawing.Point(27, 43);
            this.Lbl_Bilgi.Name = "Lbl_Bilgi";
            this.Lbl_Bilgi.Size = new System.Drawing.Size(0, 20);
            this.Lbl_Bilgi.TabIndex = 3;
            // 
            // Frm_Kontrol_Ekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(1308, 553);
            this.Controls.Add(this.Lbl_Bilgi);
            this.Controls.Add(this.button_Cıkıs);
            this.Controls.Add(this.button_Dosya_Secimi);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Frm_Kontrol_Ekrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Kontrol_Ekrani";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button_Dosya_Secimi;
        private System.Windows.Forms.Button button_Cıkıs;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nasılKullanılırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neleriKontrolEdebilirimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosyaSeçimButonuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bulunanHatalarNeredeToolStripMenuItem;
        private System.Windows.Forms.Label Lbl_Bilgi;
    }
}