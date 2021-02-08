
namespace Tez_Kontrol_Sistemi_Firat
{
    partial class Frm_Üye_Ekle
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tez_KontrolDataSet1 = new Tez_Kontrol_Sistemi_Firat.Tez_KontrolDataSet1();
            this.login_DataTableAdapter = new Tez_Kontrol_Sistemi_Firat.Tez_KontrolDataSet1TableAdapters.Login_DataTableAdapter();
            this.button_Üyeyi_Ekle = new System.Windows.Forms.Button();
            this.button_Üye_Sil = new System.Windows.Forms.Button();
            this.button_Üye_Güncelleme = new System.Windows.Forms.Button();
            this.label_Adi = new System.Windows.Forms.Label();
            this.label_Soyadi = new System.Windows.Forms.Label();
            this.label_e_mail = new System.Windows.Forms.Label();
            this.label_K_Adi = new System.Windows.Forms.Label();
            this.label_Parola = new System.Windows.Forms.Label();
            this.textBox_Adi = new System.Windows.Forms.TextBox();
            this.textBox_Soyadi = new System.Windows.Forms.TextBox();
            this.textBox_e_maili = new System.Windows.Forms.TextBox();
            this.textBox_K_Adi = new System.Windows.Forms.TextBox();
            this.textBox_Parola = new System.Windows.Forms.TextBox();
            this.label_Sil_e_mail = new System.Windows.Forms.Label();
            this.textBox_Silinen_Mail = new System.Windows.Forms.TextBox();
            this.label_Güncelle_e_mail = new System.Windows.Forms.Label();
            this.textBox_Güncellenen_Mail = new System.Windows.Forms.TextBox();
            this.button_Cıkıs_Yap = new System.Windows.Forms.Button();
            this.label_Parola_Tekrar = new System.Windows.Forms.Label();
            this.textBox_Parola_Tekrar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tez_KontrolDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adiDataGridViewTextBoxColumn,
            this.soyadiDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.kAdiDataGridViewTextBoxColumn,
            this.sifreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.loginDataBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1541, 431);
            this.dataGridView1.TabIndex = 0;
            // 
            // adiDataGridViewTextBoxColumn
            // 
            this.adiDataGridViewTextBoxColumn.DataPropertyName = "Adi";
            this.adiDataGridViewTextBoxColumn.HeaderText = "Adi";
            this.adiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adiDataGridViewTextBoxColumn.Name = "adiDataGridViewTextBoxColumn";
            this.adiDataGridViewTextBoxColumn.Width = 125;
            // 
            // soyadiDataGridViewTextBoxColumn
            // 
            this.soyadiDataGridViewTextBoxColumn.DataPropertyName = "Soyadi";
            this.soyadiDataGridViewTextBoxColumn.HeaderText = "Soyadi";
            this.soyadiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadiDataGridViewTextBoxColumn.Name = "soyadiDataGridViewTextBoxColumn";
            this.soyadiDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "e_mail";
            this.emailDataGridViewTextBoxColumn.HeaderText = "e_mail";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // kAdiDataGridViewTextBoxColumn
            // 
            this.kAdiDataGridViewTextBoxColumn.DataPropertyName = "K_Adi";
            this.kAdiDataGridViewTextBoxColumn.HeaderText = "K_Adi";
            this.kAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kAdiDataGridViewTextBoxColumn.Name = "kAdiDataGridViewTextBoxColumn";
            this.kAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // sifreDataGridViewTextBoxColumn
            // 
            this.sifreDataGridViewTextBoxColumn.DataPropertyName = "Sifre";
            this.sifreDataGridViewTextBoxColumn.HeaderText = "Sifre";
            this.sifreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sifreDataGridViewTextBoxColumn.Name = "sifreDataGridViewTextBoxColumn";
            this.sifreDataGridViewTextBoxColumn.Width = 125;
            // 
            // loginDataBindingSource
            // 
            this.loginDataBindingSource.DataMember = "Login_Data";
            this.loginDataBindingSource.DataSource = this.tez_KontrolDataSet1;
            // 
            // tez_KontrolDataSet1
            // 
            this.tez_KontrolDataSet1.DataSetName = "Tez_KontrolDataSet1";
            this.tez_KontrolDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // login_DataTableAdapter
            // 
            this.login_DataTableAdapter.ClearBeforeFill = true;
            // 
            // button_Üyeyi_Ekle
            // 
            this.button_Üyeyi_Ekle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Üyeyi_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Üyeyi_Ekle.ForeColor = System.Drawing.Color.Maroon;
            this.button_Üyeyi_Ekle.Location = new System.Drawing.Point(12, 466);
            this.button_Üyeyi_Ekle.Name = "button_Üyeyi_Ekle";
            this.button_Üyeyi_Ekle.Size = new System.Drawing.Size(243, 83);
            this.button_Üyeyi_Ekle.TabIndex = 1;
            this.button_Üyeyi_Ekle.Text = "ÜYEYİ EKLE";
            this.button_Üyeyi_Ekle.UseVisualStyleBackColor = false;
            this.button_Üyeyi_Ekle.Click += new System.EventHandler(this.button_Üyeyi_Ekle_Click);
            // 
            // button_Üye_Sil
            // 
            this.button_Üye_Sil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Üye_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Üye_Sil.ForeColor = System.Drawing.Color.Maroon;
            this.button_Üye_Sil.Location = new System.Drawing.Point(12, 596);
            this.button_Üye_Sil.Name = "button_Üye_Sil";
            this.button_Üye_Sil.Size = new System.Drawing.Size(243, 83);
            this.button_Üye_Sil.TabIndex = 1;
            this.button_Üye_Sil.Text = "ÜYEYİ SİL";
            this.button_Üye_Sil.UseVisualStyleBackColor = false;
            this.button_Üye_Sil.Click += new System.EventHandler(this.button_Üye_Sil_Click);
            // 
            // button_Üye_Güncelleme
            // 
            this.button_Üye_Güncelleme.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Üye_Güncelleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Üye_Güncelleme.ForeColor = System.Drawing.Color.Maroon;
            this.button_Üye_Güncelleme.Location = new System.Drawing.Point(12, 726);
            this.button_Üye_Güncelleme.Name = "button_Üye_Güncelleme";
            this.button_Üye_Güncelleme.Size = new System.Drawing.Size(243, 83);
            this.button_Üye_Güncelleme.TabIndex = 1;
            this.button_Üye_Güncelleme.Text = "ÜYEYİ GÜNCELLE";
            this.button_Üye_Güncelleme.UseVisualStyleBackColor = false;
            this.button_Üye_Güncelleme.Click += new System.EventHandler(this.button_Üye_Güncelleme_Click);
            // 
            // label_Adi
            // 
            this.label_Adi.AutoSize = true;
            this.label_Adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Adi.Location = new System.Drawing.Point(529, 564);
            this.label_Adi.Name = "label_Adi";
            this.label_Adi.Size = new System.Drawing.Size(80, 20);
            this.label_Adi.TabIndex = 2;
            this.label_Adi.Text = "ADINIZ :";
            // 
            // label_Soyadi
            // 
            this.label_Soyadi.AutoSize = true;
            this.label_Soyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Soyadi.Location = new System.Drawing.Point(515, 611);
            this.label_Soyadi.Name = "label_Soyadi";
            this.label_Soyadi.Size = new System.Drawing.Size(117, 20);
            this.label_Soyadi.TabIndex = 2;
            this.label_Soyadi.Text = "SOYADINIZ :";
            // 
            // label_e_mail
            // 
            this.label_e_mail.AutoSize = true;
            this.label_e_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_e_mail.Location = new System.Drawing.Point(517, 658);
            this.label_e_mail.Name = "label_e_mail";
            this.label_e_mail.Size = new System.Drawing.Size(115, 20);
            this.label_e_mail.TabIndex = 2;
            this.label_e_mail.Text = "E MAİLİNİZ :";
            // 
            // label_K_Adi
            // 
            this.label_K_Adi.AutoSize = true;
            this.label_K_Adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_K_Adi.Location = new System.Drawing.Point(521, 705);
            this.label_K_Adi.Name = "label_K_Adi";
            this.label_K_Adi.Size = new System.Drawing.Size(102, 20);
            this.label_K_Adi.TabIndex = 2;
            this.label_K_Adi.Text = "K_ADINIZ :";
            // 
            // label_Parola
            // 
            this.label_Parola.AutoSize = true;
            this.label_Parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Parola.Location = new System.Drawing.Point(512, 752);
            this.label_Parola.Name = "label_Parola";
            this.label_Parola.Size = new System.Drawing.Size(123, 20);
            this.label_Parola.TabIndex = 2;
            this.label_Parola.Text = "PAROLANIZ :";
            // 
            // textBox_Adi
            // 
            this.textBox_Adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Adi.Location = new System.Drawing.Point(651, 564);
            this.textBox_Adi.Name = "textBox_Adi";
            this.textBox_Adi.Size = new System.Drawing.Size(314, 27);
            this.textBox_Adi.TabIndex = 3;
            // 
            // textBox_Soyadi
            // 
            this.textBox_Soyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Soyadi.Location = new System.Drawing.Point(651, 608);
            this.textBox_Soyadi.Name = "textBox_Soyadi";
            this.textBox_Soyadi.Size = new System.Drawing.Size(314, 27);
            this.textBox_Soyadi.TabIndex = 3;
            // 
            // textBox_e_maili
            // 
            this.textBox_e_maili.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_e_maili.Location = new System.Drawing.Point(651, 658);
            this.textBox_e_maili.Name = "textBox_e_maili";
            this.textBox_e_maili.Size = new System.Drawing.Size(314, 27);
            this.textBox_e_maili.TabIndex = 3;
            // 
            // textBox_K_Adi
            // 
            this.textBox_K_Adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_K_Adi.Location = new System.Drawing.Point(651, 705);
            this.textBox_K_Adi.Name = "textBox_K_Adi";
            this.textBox_K_Adi.Size = new System.Drawing.Size(314, 27);
            this.textBox_K_Adi.TabIndex = 3;
            // 
            // textBox_Parola
            // 
            this.textBox_Parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Parola.Location = new System.Drawing.Point(651, 752);
            this.textBox_Parola.Name = "textBox_Parola";
            this.textBox_Parola.Size = new System.Drawing.Size(314, 27);
            this.textBox_Parola.TabIndex = 3;
            // 
            // label_Sil_e_mail
            // 
            this.label_Sil_e_mail.AutoSize = true;
            this.label_Sil_e_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Sil_e_mail.Location = new System.Drawing.Point(576, 879);
            this.label_Sil_e_mail.Name = "label_Sil_e_mail";
            this.label_Sil_e_mail.Size = new System.Drawing.Size(267, 20);
            this.label_Sil_e_mail.TabIndex = 2;
            this.label_Sil_e_mail.Text = "SİLMEK İSTEDİĞİNİZ E MAİL :";
            // 
            // textBox_Silinen_Mail
            // 
            this.textBox_Silinen_Mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Silinen_Mail.Location = new System.Drawing.Point(904, 872);
            this.textBox_Silinen_Mail.Name = "textBox_Silinen_Mail";
            this.textBox_Silinen_Mail.Size = new System.Drawing.Size(314, 27);
            this.textBox_Silinen_Mail.TabIndex = 3;
            // 
            // label_Güncelle_e_mail
            // 
            this.label_Güncelle_e_mail.AutoSize = true;
            this.label_Güncelle_e_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Güncelle_e_mail.Location = new System.Drawing.Point(505, 919);
            this.label_Güncelle_e_mail.Name = "label_Güncelle_e_mail";
            this.label_Güncelle_e_mail.Size = new System.Drawing.Size(338, 20);
            this.label_Güncelle_e_mail.TabIndex = 2;
            this.label_Güncelle_e_mail.Text = "GÜNCELLEMEK İSTEDİĞİNİZ E MAİL :";
            // 
            // textBox_Güncellenen_Mail
            // 
            this.textBox_Güncellenen_Mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Güncellenen_Mail.Location = new System.Drawing.Point(904, 912);
            this.textBox_Güncellenen_Mail.Name = "textBox_Güncellenen_Mail";
            this.textBox_Güncellenen_Mail.Size = new System.Drawing.Size(314, 27);
            this.textBox_Güncellenen_Mail.TabIndex = 3;
            // 
            // button_Cıkıs_Yap
            // 
            this.button_Cıkıs_Yap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Cıkıs_Yap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Cıkıs_Yap.ForeColor = System.Drawing.Color.Maroon;
            this.button_Cıkıs_Yap.Location = new System.Drawing.Point(12, 856);
            this.button_Cıkıs_Yap.Name = "button_Cıkıs_Yap";
            this.button_Cıkıs_Yap.Size = new System.Drawing.Size(243, 83);
            this.button_Cıkıs_Yap.TabIndex = 4;
            this.button_Cıkıs_Yap.Text = "ÇIKIŞ YAP";
            this.button_Cıkıs_Yap.UseVisualStyleBackColor = false;
            this.button_Cıkıs_Yap.Click += new System.EventHandler(this.button_Cıkıs_Yap_Click);
            // 
            // label_Parola_Tekrar
            // 
            this.label_Parola_Tekrar.AutoSize = true;
            this.label_Parola_Tekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Parola_Tekrar.Location = new System.Drawing.Point(430, 806);
            this.label_Parola_Tekrar.Name = "label_Parola_Tekrar";
            this.label_Parola_Tekrar.Size = new System.Drawing.Size(202, 20);
            this.label_Parola_Tekrar.TabIndex = 2;
            this.label_Parola_Tekrar.Text = "PAROLANIZ TEKRAR :";
            // 
            // textBox_Parola_Tekrar
            // 
            this.textBox_Parola_Tekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Parola_Tekrar.Location = new System.Drawing.Point(651, 799);
            this.textBox_Parola_Tekrar.Name = "textBox_Parola_Tekrar";
            this.textBox_Parola_Tekrar.Size = new System.Drawing.Size(314, 27);
            this.textBox_Parola_Tekrar.TabIndex = 3;
            // 
            // Frm_Üye_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1559, 967);
            this.Controls.Add(this.button_Cıkıs_Yap);
            this.Controls.Add(this.textBox_Parola_Tekrar);
            this.Controls.Add(this.textBox_Parola);
            this.Controls.Add(this.textBox_K_Adi);
            this.Controls.Add(this.textBox_Güncellenen_Mail);
            this.Controls.Add(this.textBox_Silinen_Mail);
            this.Controls.Add(this.textBox_e_maili);
            this.Controls.Add(this.textBox_Soyadi);
            this.Controls.Add(this.textBox_Adi);
            this.Controls.Add(this.label_Parola_Tekrar);
            this.Controls.Add(this.label_Parola);
            this.Controls.Add(this.label_K_Adi);
            this.Controls.Add(this.label_Güncelle_e_mail);
            this.Controls.Add(this.label_Sil_e_mail);
            this.Controls.Add(this.label_e_mail);
            this.Controls.Add(this.label_Soyadi);
            this.Controls.Add(this.label_Adi);
            this.Controls.Add(this.button_Üye_Güncelleme);
            this.Controls.Add(this.button_Üye_Sil);
            this.Controls.Add(this.button_Üyeyi_Ekle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Frm_Üye_Ekle";
            this.Text = "Frm_Üye_Ekle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Üye_Ekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tez_KontrolDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Tez_KontrolDataSet1 tez_KontrolDataSet1;
        private System.Windows.Forms.BindingSource loginDataBindingSource;
        private Tez_KontrolDataSet1TableAdapters.Login_DataTableAdapter login_DataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn adiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_Üyeyi_Ekle;
        private System.Windows.Forms.Button button_Üye_Sil;
        private System.Windows.Forms.Button button_Üye_Güncelleme;
        private System.Windows.Forms.Label label_Adi;
        private System.Windows.Forms.Label label_Soyadi;
        private System.Windows.Forms.Label label_e_mail;
        private System.Windows.Forms.Label label_K_Adi;
        private System.Windows.Forms.Label label_Parola;
        private System.Windows.Forms.TextBox textBox_Adi;
        private System.Windows.Forms.TextBox textBox_Soyadi;
        private System.Windows.Forms.TextBox textBox_e_maili;
        private System.Windows.Forms.TextBox textBox_K_Adi;
        private System.Windows.Forms.TextBox textBox_Parola;
        private System.Windows.Forms.Label label_Sil_e_mail;
        private System.Windows.Forms.TextBox textBox_Silinen_Mail;
        private System.Windows.Forms.Label label_Güncelle_e_mail;
        private System.Windows.Forms.TextBox textBox_Güncellenen_Mail;
        private System.Windows.Forms.Button button_Cıkıs_Yap;
        private System.Windows.Forms.Label label_Parola_Tekrar;
        private System.Windows.Forms.TextBox textBox_Parola_Tekrar;
    }
}