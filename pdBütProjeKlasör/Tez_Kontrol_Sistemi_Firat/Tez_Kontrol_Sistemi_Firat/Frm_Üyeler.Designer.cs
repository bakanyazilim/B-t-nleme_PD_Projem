
namespace Tez_Kontrol_Sistemi_Firat
{
    partial class Frm_Üyeler
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
            this.Lbl_Üst_Bilgi = new System.Windows.Forms.Label();
            this.tez_KontrolDataSet1 = new Tez_Kontrol_Sistemi_Firat.Tez_KontrolDataSet1();
            this.loginDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.login_DataTableAdapter = new Tez_Kontrol_Sistemi_Firat.Tez_KontrolDataSet1TableAdapters.Login_DataTableAdapter();
            this.tez_KontrolDataSet = new Tez_Kontrol_Sistemi_Firat.Tez_KontrolDataSet();
            this.tezKontrolDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tezKontrolDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.loginDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.adiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Göster = new System.Windows.Forms.Button();
            this.button_Üye_Ekle = new System.Windows.Forms.Button();
            this.button_Cıkıs_Yap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tez_KontrolDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tez_KontrolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tezKontrolDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tezKontrolDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Üst_Bilgi
            // 
            this.Lbl_Üst_Bilgi.AutoSize = true;
            this.Lbl_Üst_Bilgi.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Üst_Bilgi.Location = new System.Drawing.Point(261, 26);
            this.Lbl_Üst_Bilgi.Name = "Lbl_Üst_Bilgi";
            this.Lbl_Üst_Bilgi.Size = new System.Drawing.Size(718, 43);
            this.Lbl_Üst_Bilgi.TabIndex = 0;
            this.Lbl_Üst_Bilgi.Text = "ÜYE İŞLEMLERİ SAYFASINA HOŞGELDİNİZ ";
            // 
            // tez_KontrolDataSet1
            // 
            this.tez_KontrolDataSet1.DataSetName = "Tez_KontrolDataSet1";
            this.tez_KontrolDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginDataBindingSource
            // 
            this.loginDataBindingSource.DataMember = "Login_Data";
            this.loginDataBindingSource.DataSource = this.tez_KontrolDataSet1;
            // 
            // login_DataTableAdapter
            // 
            this.login_DataTableAdapter.ClearBeforeFill = true;
            // 
            // tez_KontrolDataSet
            // 
            this.tez_KontrolDataSet.DataSetName = "Tez_KontrolDataSet";
            this.tez_KontrolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tezKontrolDataSetBindingSource
            // 
            this.tezKontrolDataSetBindingSource.DataSource = this.tez_KontrolDataSet;
            this.tezKontrolDataSetBindingSource.Position = 0;
            // 
            // tezKontrolDataSet1BindingSource
            // 
            this.tezKontrolDataSet1BindingSource.DataSource = this.tez_KontrolDataSet1;
            this.tezKontrolDataSet1BindingSource.Position = 0;
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
            this.dataGridView1.DataSource = this.loginDataBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(408, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(859, 545);
            this.dataGridView1.TabIndex = 1;
            // 
            // loginDataBindingSource1
            // 
            this.loginDataBindingSource1.DataMember = "Login_Data";
            this.loginDataBindingSource1.DataSource = this.tez_KontrolDataSet1;
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
            // button_Göster
            // 
            this.button_Göster.BackColor = System.Drawing.Color.Yellow;
            this.button_Göster.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Göster.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.button_Göster.Location = new System.Drawing.Point(129, 202);
            this.button_Göster.Name = "button_Göster";
            this.button_Göster.Size = new System.Drawing.Size(237, 87);
            this.button_Göster.TabIndex = 2;
            this.button_Göster.Text = "ÜYELERİ GÖSTER";
            this.button_Göster.UseVisualStyleBackColor = false;
            this.button_Göster.Click += new System.EventHandler(this.button_Göster_Click);
            // 
            // button_Üye_Ekle
            // 
            this.button_Üye_Ekle.BackColor = System.Drawing.Color.Cyan;
            this.button_Üye_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Üye_Ekle.ForeColor = System.Drawing.Color.Olive;
            this.button_Üye_Ekle.Location = new System.Drawing.Point(129, 352);
            this.button_Üye_Ekle.Name = "button_Üye_Ekle";
            this.button_Üye_Ekle.Size = new System.Drawing.Size(237, 87);
            this.button_Üye_Ekle.TabIndex = 2;
            this.button_Üye_Ekle.Text = "ÜYE EKLE";
            this.button_Üye_Ekle.UseVisualStyleBackColor = false;
            this.button_Üye_Ekle.Click += new System.EventHandler(this.button_Üye_Ekle_Click);
            // 
            // button_Cıkıs_Yap
            // 
            this.button_Cıkıs_Yap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Cıkıs_Yap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Cıkıs_Yap.ForeColor = System.Drawing.Color.Maroon;
            this.button_Cıkıs_Yap.Location = new System.Drawing.Point(129, 502);
            this.button_Cıkıs_Yap.Name = "button_Cıkıs_Yap";
            this.button_Cıkıs_Yap.Size = new System.Drawing.Size(243, 83);
            this.button_Cıkıs_Yap.TabIndex = 3;
            this.button_Cıkıs_Yap.Text = "ÇIKIŞ YAP";
            this.button_Cıkıs_Yap.UseVisualStyleBackColor = false;
            this.button_Cıkıs_Yap.Click += new System.EventHandler(this.button_Cıkıs_Yap_Click);
            // 
            // Frm_Üyeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1263, 629);
            this.Controls.Add(this.button_Cıkıs_Yap);
            this.Controls.Add(this.button_Üye_Ekle);
            this.Controls.Add(this.button_Göster);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Lbl_Üst_Bilgi);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Frm_Üyeler";
            this.Text = "Frm_Üyeler";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Üyeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tez_KontrolDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tez_KontrolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tezKontrolDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tezKontrolDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Üst_Bilgi;
        private Tez_KontrolDataSet1 tez_KontrolDataSet1;
        private System.Windows.Forms.BindingSource loginDataBindingSource;
        private Tez_KontrolDataSet1TableAdapters.Login_DataTableAdapter login_DataTableAdapter;
        private Tez_KontrolDataSet tez_KontrolDataSet;
        private System.Windows.Forms.BindingSource tezKontrolDataSetBindingSource;
        private System.Windows.Forms.BindingSource tezKontrolDataSet1BindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource loginDataBindingSource1;
        private System.Windows.Forms.Button button_Göster;
        private System.Windows.Forms.Button button_Üye_Ekle;
        private System.Windows.Forms.Button button_Cıkıs_Yap;
    }
}