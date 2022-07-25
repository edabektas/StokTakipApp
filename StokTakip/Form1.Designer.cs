
namespace StokTakip
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grb_kayıtIslemleri = new System.Windows.Forms.GroupBox();
            this.txb_magaza = new System.Windows.Forms.TextBox();
            this.txb_kayitNo = new System.Windows.Forms.TextBox();
            this.txb_stokSeriNo = new System.Windows.Forms.TextBox();
            this.dateTime_stokTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmb_stokBedeni = new System.Windows.Forms.ComboBox();
            this.txb_kayıtYapan = new System.Windows.Forms.TextBox();
            this.txb_stokAdedi = new System.Windows.Forms.TextBox();
            this.txb_stokModeli = new System.Windows.Forms.TextBox();
            this.txb_stokAdi = new System.Windows.Forms.TextBox();
            this.lbl_stokAdı = new System.Windows.Forms.Label();
            this.lbl_stokModeli = new System.Windows.Forms.Label();
            this.lbl_stokBedeni = new System.Windows.Forms.Label();
            this.lbl_stokAdedi = new System.Windows.Forms.Label();
            this.lbl_stokTarihi = new System.Windows.Forms.Label();
            this.lbl_kayıtYapan = new System.Windows.Forms.Label();
            this.txb_stokAra = new System.Windows.Forms.TextBox();
            this.btn_stokAra = new System.Windows.Forms.Button();
            this.grb_stokAra = new System.Windows.Forms.GroupBox();
            this.txb_stokAra_magaza = new System.Windows.Forms.TextBox();
            this.txb_stokAra_kayitYapan = new System.Windows.Forms.TextBox();
            this.txb_stokAra_stokBedeni = new System.Windows.Forms.TextBox();
            this.txb_stokAra_stokModeli = new System.Windows.Forms.TextBox();
            this.txb_stokAra_stokAdi = new System.Windows.Forms.TextBox();
            this.btn_stokEkle = new System.Windows.Forms.Button();
            this.btn_stokGüncelle = new System.Windows.Forms.Button();
            this.btn_stokSil = new System.Windows.Forms.Button();
            this.lbl_stokSeriNo = new System.Windows.Forms.Label();
            this.data_stokTakip = new System.Windows.Forms.DataGridView();
            this.lbl_kayitNo = new System.Windows.Forms.Label();
            this.lbl_magaza = new System.Windows.Forms.Label();
            this.grb_kayıtIslemleri.SuspendLayout();
            this.grb_stokAra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_stokTakip)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_kayıtIslemleri
            // 
            this.grb_kayıtIslemleri.Controls.Add(this.txb_magaza);
            this.grb_kayıtIslemleri.Controls.Add(this.txb_kayitNo);
            this.grb_kayıtIslemleri.Controls.Add(this.txb_stokSeriNo);
            this.grb_kayıtIslemleri.Controls.Add(this.dateTime_stokTarihi);
            this.grb_kayıtIslemleri.Controls.Add(this.cmb_stokBedeni);
            this.grb_kayıtIslemleri.Controls.Add(this.txb_kayıtYapan);
            this.grb_kayıtIslemleri.Controls.Add(this.txb_stokAdedi);
            this.grb_kayıtIslemleri.Controls.Add(this.txb_stokModeli);
            this.grb_kayıtIslemleri.Controls.Add(this.txb_stokAdi);
            this.grb_kayıtIslemleri.Location = new System.Drawing.Point(184, 8);
            this.grb_kayıtIslemleri.Name = "grb_kayıtIslemleri";
            this.grb_kayıtIslemleri.Size = new System.Drawing.Size(304, 408);
            this.grb_kayıtIslemleri.TabIndex = 0;
            this.grb_kayıtIslemleri.TabStop = false;
            this.grb_kayıtIslemleri.Text = "Kayıt İşlemleri";
            // 
            // txb_magaza
            // 
            this.txb_magaza.Location = new System.Drawing.Point(6, 362);
            this.txb_magaza.MaxLength = 20;
            this.txb_magaza.Multiline = true;
            this.txb_magaza.Name = "txb_magaza";
            this.txb_magaza.Size = new System.Drawing.Size(249, 26);
            this.txb_magaza.TabIndex = 17;
            // 
            // txb_kayitNo
            // 
            this.txb_kayitNo.Enabled = false;
            this.txb_kayitNo.Location = new System.Drawing.Point(6, 57);
            this.txb_kayitNo.Multiline = true;
            this.txb_kayitNo.Name = "txb_kayitNo";
            this.txb_kayitNo.Size = new System.Drawing.Size(249, 26);
            this.txb_kayitNo.TabIndex = 1;
            // 
            // txb_stokSeriNo
            // 
            this.txb_stokSeriNo.Location = new System.Drawing.Point(6, 171);
            this.txb_stokSeriNo.MaxLength = 10;
            this.txb_stokSeriNo.Multiline = true;
            this.txb_stokSeriNo.Name = "txb_stokSeriNo";
            this.txb_stokSeriNo.Size = new System.Drawing.Size(249, 26);
            this.txb_stokSeriNo.TabIndex = 7;
            // 
            // dateTime_stokTarihi
            // 
            this.dateTime_stokTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_stokTarihi.Location = new System.Drawing.Point(6, 288);
            this.dateTime_stokTarihi.Name = "dateTime_stokTarihi";
            this.dateTime_stokTarihi.Size = new System.Drawing.Size(249, 27);
            this.dateTime_stokTarihi.TabIndex = 13;
            // 
            // cmb_stokBedeni
            // 
            this.cmb_stokBedeni.FormattingEnabled = true;
            this.cmb_stokBedeni.Items.AddRange(new object[] {
            "XS",
            "S",
            "M",
            "L",
            "XL",
            "XXL"});
            this.cmb_stokBedeni.Location = new System.Drawing.Point(6, 211);
            this.cmb_stokBedeni.Name = "cmb_stokBedeni";
            this.cmb_stokBedeni.Size = new System.Drawing.Size(249, 28);
            this.cmb_stokBedeni.TabIndex = 9;
            // 
            // txb_kayıtYapan
            // 
            this.txb_kayıtYapan.Location = new System.Drawing.Point(6, 324);
            this.txb_kayıtYapan.MaxLength = 20;
            this.txb_kayıtYapan.Multiline = true;
            this.txb_kayıtYapan.Name = "txb_kayıtYapan";
            this.txb_kayıtYapan.Size = new System.Drawing.Size(249, 26);
            this.txb_kayıtYapan.TabIndex = 15;
            // 
            // txb_stokAdedi
            // 
            this.txb_stokAdedi.Location = new System.Drawing.Point(6, 248);
            this.txb_stokAdedi.Multiline = true;
            this.txb_stokAdedi.Name = "txb_stokAdedi";
            this.txb_stokAdedi.Size = new System.Drawing.Size(249, 26);
            this.txb_stokAdedi.TabIndex = 11;
            // 
            // txb_stokModeli
            // 
            this.txb_stokModeli.Location = new System.Drawing.Point(6, 133);
            this.txb_stokModeli.MaxLength = 50;
            this.txb_stokModeli.Multiline = true;
            this.txb_stokModeli.Name = "txb_stokModeli";
            this.txb_stokModeli.Size = new System.Drawing.Size(249, 26);
            this.txb_stokModeli.TabIndex = 5;
            // 
            // txb_stokAdi
            // 
            this.txb_stokAdi.Location = new System.Drawing.Point(6, 95);
            this.txb_stokAdi.MaxLength = 20;
            this.txb_stokAdi.Multiline = true;
            this.txb_stokAdi.Name = "txb_stokAdi";
            this.txb_stokAdi.Size = new System.Drawing.Size(249, 26);
            this.txb_stokAdi.TabIndex = 3;
            // 
            // lbl_stokAdı
            // 
            this.lbl_stokAdı.AutoSize = true;
            this.lbl_stokAdı.Location = new System.Drawing.Point(72, 109);
            this.lbl_stokAdı.Name = "lbl_stokAdı";
            this.lbl_stokAdı.Size = new System.Drawing.Size(73, 20);
            this.lbl_stokAdı.TabIndex = 4;
            this.lbl_stokAdı.Text = "STOK ADI";
            // 
            // lbl_stokModeli
            // 
            this.lbl_stokModeli.AutoSize = true;
            this.lbl_stokModeli.Location = new System.Drawing.Point(72, 146);
            this.lbl_stokModeli.Name = "lbl_stokModeli";
            this.lbl_stokModeli.Size = new System.Drawing.Size(102, 20);
            this.lbl_stokModeli.TabIndex = 6;
            this.lbl_stokModeli.Text = "STOK MODELİ";
            // 
            // lbl_stokBedeni
            // 
            this.lbl_stokBedeni.AutoSize = true;
            this.lbl_stokBedeni.Location = new System.Drawing.Point(72, 220);
            this.lbl_stokBedeni.Name = "lbl_stokBedeni";
            this.lbl_stokBedeni.Size = new System.Drawing.Size(99, 20);
            this.lbl_stokBedeni.TabIndex = 10;
            this.lbl_stokBedeni.Text = "STOK BEDENİ";
            // 
            // lbl_stokAdedi
            // 
            this.lbl_stokAdedi.AutoSize = true;
            this.lbl_stokAdedi.Location = new System.Drawing.Point(72, 257);
            this.lbl_stokAdedi.Name = "lbl_stokAdedi";
            this.lbl_stokAdedi.Size = new System.Drawing.Size(92, 20);
            this.lbl_stokAdedi.TabIndex = 12;
            this.lbl_stokAdedi.Text = "STOK ADEDİ";
            // 
            // lbl_stokTarihi
            // 
            this.lbl_stokTarihi.AutoSize = true;
            this.lbl_stokTarihi.Location = new System.Drawing.Point(72, 294);
            this.lbl_stokTarihi.Name = "lbl_stokTarihi";
            this.lbl_stokTarihi.Size = new System.Drawing.Size(93, 20);
            this.lbl_stokTarihi.TabIndex = 14;
            this.lbl_stokTarihi.Text = "STOK TARİHİ";
            // 
            // lbl_kayıtYapan
            // 
            this.lbl_kayıtYapan.AutoSize = true;
            this.lbl_kayıtYapan.Location = new System.Drawing.Point(72, 331);
            this.lbl_kayıtYapan.Name = "lbl_kayıtYapan";
            this.lbl_kayıtYapan.Size = new System.Drawing.Size(96, 20);
            this.lbl_kayıtYapan.TabIndex = 16;
            this.lbl_kayıtYapan.Text = "KAYIT YAPAN";
            // 
            // txb_stokAra
            // 
            this.txb_stokAra.Location = new System.Drawing.Point(6, 138);
            this.txb_stokAra.Name = "txb_stokAra";
            this.txb_stokAra.PlaceholderText = "Stok Seri No";
            this.txb_stokAra.Size = new System.Drawing.Size(218, 27);
            this.txb_stokAra.TabIndex = 21;
            this.txb_stokAra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txb_stokAra_KeyUp);
            // 
            // btn_stokAra
            // 
            this.btn_stokAra.Location = new System.Drawing.Point(135, 231);
            this.btn_stokAra.Name = "btn_stokAra";
            this.btn_stokAra.Size = new System.Drawing.Size(261, 43);
            this.btn_stokAra.TabIndex = 25;
            this.btn_stokAra.Text = "ARA";
            this.btn_stokAra.UseVisualStyleBackColor = true;
            this.btn_stokAra.Click += new System.EventHandler(this.btn_stokAra_Click);
            // 
            // grb_stokAra
            // 
            this.grb_stokAra.Controls.Add(this.txb_stokAra_magaza);
            this.grb_stokAra.Controls.Add(this.txb_stokAra_kayitYapan);
            this.grb_stokAra.Controls.Add(this.txb_stokAra_stokBedeni);
            this.grb_stokAra.Controls.Add(this.txb_stokAra_stokModeli);
            this.grb_stokAra.Controls.Add(this.txb_stokAra_stokAdi);
            this.grb_stokAra.Controls.Add(this.btn_stokAra);
            this.grb_stokAra.Controls.Add(this.txb_stokAra);
            this.grb_stokAra.Location = new System.Drawing.Point(509, 8);
            this.grb_stokAra.Name = "grb_stokAra";
            this.grb_stokAra.Size = new System.Drawing.Size(550, 315);
            this.grb_stokAra.TabIndex = 11;
            this.grb_stokAra.TabStop = false;
            this.grb_stokAra.Text = "STOK ARA";
            // 
            // txb_stokAra_magaza
            // 
            this.txb_stokAra_magaza.Location = new System.Drawing.Point(259, 138);
            this.txb_stokAra_magaza.Name = "txb_stokAra_magaza";
            this.txb_stokAra_magaza.PlaceholderText = "Mağaza";
            this.txb_stokAra_magaza.Size = new System.Drawing.Size(218, 27);
            this.txb_stokAra_magaza.TabIndex = 24;
            this.txb_stokAra_magaza.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txb_stokAra_magaza_KeyUp);
            // 
            // txb_stokAra_kayitYapan
            // 
            this.txb_stokAra_kayitYapan.Location = new System.Drawing.Point(259, 82);
            this.txb_stokAra_kayitYapan.Name = "txb_stokAra_kayitYapan";
            this.txb_stokAra_kayitYapan.PlaceholderText = "Kayıt Yapan";
            this.txb_stokAra_kayitYapan.Size = new System.Drawing.Size(218, 27);
            this.txb_stokAra_kayitYapan.TabIndex = 23;
            this.txb_stokAra_kayitYapan.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txb_stokAra_kayitYapan_KeyUp);
            // 
            // txb_stokAra_stokBedeni
            // 
            this.txb_stokAra_stokBedeni.Location = new System.Drawing.Point(259, 26);
            this.txb_stokAra_stokBedeni.Name = "txb_stokAra_stokBedeni";
            this.txb_stokAra_stokBedeni.PlaceholderText = "Stok Bedeni";
            this.txb_stokAra_stokBedeni.Size = new System.Drawing.Size(218, 27);
            this.txb_stokAra_stokBedeni.TabIndex = 22;
            this.txb_stokAra_stokBedeni.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txb_stokAra_stokBedeni_KeyUp);
            // 
            // txb_stokAra_stokModeli
            // 
            this.txb_stokAra_stokModeli.Location = new System.Drawing.Point(6, 82);
            this.txb_stokAra_stokModeli.Name = "txb_stokAra_stokModeli";
            this.txb_stokAra_stokModeli.PlaceholderText = "Stok Modeli";
            this.txb_stokAra_stokModeli.Size = new System.Drawing.Size(218, 27);
            this.txb_stokAra_stokModeli.TabIndex = 20;
            this.txb_stokAra_stokModeli.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txb_stokAra_stokModeli_KeyUp);
            // 
            // txb_stokAra_stokAdi
            // 
            this.txb_stokAra_stokAdi.Location = new System.Drawing.Point(6, 26);
            this.txb_stokAra_stokAdi.Name = "txb_stokAra_stokAdi";
            this.txb_stokAra_stokAdi.PlaceholderText = "Stok Adı";
            this.txb_stokAra_stokAdi.Size = new System.Drawing.Size(218, 27);
            this.txb_stokAra_stokAdi.TabIndex = 19;
            this.txb_stokAra_stokAdi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txb_stokAra_stokAdi_KeyUp);
            // 
            // btn_stokEkle
            // 
            this.btn_stokEkle.Location = new System.Drawing.Point(515, 340);
            this.btn_stokEkle.Name = "btn_stokEkle";
            this.btn_stokEkle.Size = new System.Drawing.Size(144, 48);
            this.btn_stokEkle.TabIndex = 26;
            this.btn_stokEkle.Text = "STOK EKLE";
            this.btn_stokEkle.UseVisualStyleBackColor = true;
            this.btn_stokEkle.Click += new System.EventHandler(this.btn_stokEkle_Click);
            // 
            // btn_stokGüncelle
            // 
            this.btn_stokGüncelle.Location = new System.Drawing.Point(717, 340);
            this.btn_stokGüncelle.Name = "btn_stokGüncelle";
            this.btn_stokGüncelle.Size = new System.Drawing.Size(144, 48);
            this.btn_stokGüncelle.TabIndex = 27;
            this.btn_stokGüncelle.Text = "STOK GÜNCELLE";
            this.btn_stokGüncelle.UseVisualStyleBackColor = true;
            this.btn_stokGüncelle.Click += new System.EventHandler(this.btn_stokGüncelle_Click);
            // 
            // btn_stokSil
            // 
            this.btn_stokSil.Location = new System.Drawing.Point(915, 340);
            this.btn_stokSil.Name = "btn_stokSil";
            this.btn_stokSil.Size = new System.Drawing.Size(144, 48);
            this.btn_stokSil.TabIndex = 28;
            this.btn_stokSil.Text = "STOK SİL";
            this.btn_stokSil.UseVisualStyleBackColor = true;
            this.btn_stokSil.Click += new System.EventHandler(this.btn_stokSil_Click);
            // 
            // lbl_stokSeriNo
            // 
            this.lbl_stokSeriNo.AutoSize = true;
            this.lbl_stokSeriNo.Location = new System.Drawing.Point(72, 183);
            this.lbl_stokSeriNo.Name = "lbl_stokSeriNo";
            this.lbl_stokSeriNo.Size = new System.Drawing.Size(103, 20);
            this.lbl_stokSeriNo.TabIndex = 8;
            this.lbl_stokSeriNo.Text = "STOK SERİ NO";
            // 
            // data_stokTakip
            // 
            this.data_stokTakip.AllowUserToAddRows = false;
            this.data_stokTakip.AllowUserToDeleteRows = false;
            this.data_stokTakip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_stokTakip.Location = new System.Drawing.Point(43, 424);
            this.data_stokTakip.Name = "data_stokTakip";
            this.data_stokTakip.ReadOnly = true;
            this.data_stokTakip.RowHeadersWidth = 51;
            this.data_stokTakip.RowTemplate.Height = 29;
            this.data_stokTakip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_stokTakip.Size = new System.Drawing.Size(1037, 286);
            this.data_stokTakip.TabIndex = 29;
            this.data_stokTakip.TabStop = false;
            this.data_stokTakip.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_stokTakip_CellEnter);
            // 
            // lbl_kayitNo
            // 
            this.lbl_kayitNo.AutoSize = true;
            this.lbl_kayitNo.Location = new System.Drawing.Point(72, 72);
            this.lbl_kayitNo.Name = "lbl_kayitNo";
            this.lbl_kayitNo.Size = new System.Drawing.Size(73, 20);
            this.lbl_kayitNo.TabIndex = 2;
            this.lbl_kayitNo.Text = "KAYIT NO";
            // 
            // lbl_magaza
            // 
            this.lbl_magaza.AutoSize = true;
            this.lbl_magaza.Location = new System.Drawing.Point(72, 368);
            this.lbl_magaza.Name = "lbl_magaza";
            this.lbl_magaza.Size = new System.Drawing.Size(71, 20);
            this.lbl_magaza.TabIndex = 18;
            this.lbl_magaza.Text = "MAĞAZA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 722);
            this.Controls.Add(this.lbl_magaza);
            this.Controls.Add(this.lbl_kayitNo);
            this.Controls.Add(this.data_stokTakip);
            this.Controls.Add(this.lbl_stokSeriNo);
            this.Controls.Add(this.btn_stokSil);
            this.Controls.Add(this.btn_stokGüncelle);
            this.Controls.Add(this.btn_stokEkle);
            this.Controls.Add(this.grb_stokAra);
            this.Controls.Add(this.lbl_kayıtYapan);
            this.Controls.Add(this.lbl_stokTarihi);
            this.Controls.Add(this.lbl_stokAdedi);
            this.Controls.Add(this.lbl_stokBedeni);
            this.Controls.Add(this.lbl_stokModeli);
            this.Controls.Add(this.lbl_stokAdı);
            this.Controls.Add(this.grb_kayıtIslemleri);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StokTakip";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grb_kayıtIslemleri.ResumeLayout(false);
            this.grb_kayıtIslemleri.PerformLayout();
            this.grb_stokAra.ResumeLayout(false);
            this.grb_stokAra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_stokTakip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_kayıtIslemleri;
        private System.Windows.Forms.Label lbl_stokAdı;
        private System.Windows.Forms.Label lbl_stokModeli;
        private System.Windows.Forms.Label lbl_stokBedeni;
        private System.Windows.Forms.Label lbl_stokAdedi;
        private System.Windows.Forms.Label lbl_stokTarihi;
        private System.Windows.Forms.Label lbl_kayıtYapan;
        private System.Windows.Forms.DateTimePicker dateTime_stokTarihi;
        private System.Windows.Forms.ComboBox cmb_stokBedeni;
        private System.Windows.Forms.TextBox txb_kayıtYapan;
        private System.Windows.Forms.TextBox txb_stokAdedi;
        private System.Windows.Forms.TextBox txb_stokModeli;
        private System.Windows.Forms.TextBox txb_stokAdi;
        private System.Windows.Forms.TextBox txb_stokAra;
        private System.Windows.Forms.Button btn_stokAra;
        private System.Windows.Forms.GroupBox grb_stokAra;
        private System.Windows.Forms.Button btn_stokEkle;
        private System.Windows.Forms.Button btn_stokGüncelle;
        private System.Windows.Forms.Button btn_stokSil;
        private System.Windows.Forms.TextBox txb_stokSeriNo;
        private System.Windows.Forms.Label lbl_stokSeriNo;
        private System.Windows.Forms.DataGridView data_stokTakip;
        private System.Windows.Forms.TextBox txb_kayitNo;
        private System.Windows.Forms.Label lbl_kayitNo;
        private System.Windows.Forms.TextBox txb_magaza;
        private System.Windows.Forms.Label lbl_magaza;
        private System.Windows.Forms.TextBox txb_stokAra_magaza;
        private System.Windows.Forms.TextBox txb_stokAra_kayitYapan;
        private System.Windows.Forms.TextBox txb_stokAra_stokBedeni;
        private System.Windows.Forms.TextBox txb_stokAra_stokModeli;
        private System.Windows.Forms.TextBox txb_stokAra_stokAdi;
    }
}

