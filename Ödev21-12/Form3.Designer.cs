namespace Ödev21_12
{
    partial class Form3
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
            this.label = new System.Windows.Forms.Label();
            this.lblIndirimliTutar = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.labelOdeme = new System.Windows.Forms.Label();
            this.rbKrediKarti = new System.Windows.Forms.RadioButton();
            this.rbNakit = new System.Windows.Forms.RadioButton();
            this.btnSiparişOnay = new System.Windows.Forms.Button();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.btnToplamTutarHesapla = new System.Windows.Forms.Button();
            this.labelToplamTutar = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.labelSepet = new System.Windows.Forms.Label();
            this.lbSepet = new System.Windows.Forms.ListBox();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.labelTutar = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.labelAdet = new System.Windows.Forms.Label();
            this.lbUrunler = new System.Windows.Forms.ListBox();
            this.labelUrunler = new System.Windows.Forms.Label();
            this.btnDukkanIslemleri = new System.Windows.Forms.Button();
            this.btnYeniSatisIslemi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label.Location = new System.Drawing.Point(298, 333);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(93, 16);
            this.label.TabIndex = 73;
            this.label.Text = "İndirimli Tutar:";
            // 
            // lblIndirimliTutar
            // 
            this.lblIndirimliTutar.AutoSize = true;
            this.lblIndirimliTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIndirimliTutar.Location = new System.Drawing.Point(396, 333);
            this.lblIndirimliTutar.Name = "lblIndirimliTutar";
            this.lblIndirimliTutar.Size = new System.Drawing.Size(49, 13);
            this.lblIndirimliTutar.TabIndex = 72;
            this.lblIndirimliTutar.Text = "              ";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.Location = new System.Drawing.Point(75, 362);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(55, 13);
            this.lblTutar.TabIndex = 71;
            this.lblTutar.Text = "                ";
            // 
            // labelOdeme
            // 
            this.labelOdeme.AutoSize = true;
            this.labelOdeme.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOdeme.Location = new System.Drawing.Point(298, 291);
            this.labelOdeme.Name = "labelOdeme";
            this.labelOdeme.Size = new System.Drawing.Size(55, 17);
            this.labelOdeme.TabIndex = 70;
            this.labelOdeme.Text = "Ödeme:";
            // 
            // rbKrediKarti
            // 
            this.rbKrediKarti.AutoSize = true;
            this.rbKrediKarti.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbKrediKarti.Location = new System.Drawing.Point(443, 289);
            this.rbKrediKarti.Name = "rbKrediKarti";
            this.rbKrediKarti.Size = new System.Drawing.Size(92, 21);
            this.rbKrediKarti.TabIndex = 69;
            this.rbKrediKarti.TabStop = true;
            this.rbKrediKarti.Text = "Kredi Kartı";
            this.rbKrediKarti.UseVisualStyleBackColor = true;
            this.rbKrediKarti.CheckedChanged += new System.EventHandler(this.rbKrediKarti_CheckedChanged);
            // 
            // rbNakit
            // 
            this.rbNakit.AutoSize = true;
            this.rbNakit.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbNakit.Location = new System.Drawing.Point(370, 289);
            this.rbNakit.Name = "rbNakit";
            this.rbNakit.Size = new System.Drawing.Size(58, 21);
            this.rbNakit.TabIndex = 68;
            this.rbNakit.TabStop = true;
            this.rbNakit.Text = "Nakit";
            this.rbNakit.UseVisualStyleBackColor = true;
            this.rbNakit.CheckedChanged += new System.EventHandler(this.rbNakit_CheckedChanged);
            // 
            // btnSiparişOnay
            // 
            this.btnSiparişOnay.Location = new System.Drawing.Point(491, 319);
            this.btnSiparişOnay.Name = "btnSiparişOnay";
            this.btnSiparişOnay.Size = new System.Drawing.Size(104, 35);
            this.btnSiparişOnay.TabIndex = 67;
            this.btnSiparişOnay.Text = "Siparişi Onayla";
            this.btnSiparişOnay.UseVisualStyleBackColor = true;
            this.btnSiparişOnay.Visible = false;
            this.btnSiparişOnay.Click += new System.EventHandler(this.btnSiparişOnay_Click);
            // 
            // nudAdet
            // 
            this.nudAdet.Location = new System.Drawing.Point(69, 324);
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(54, 20);
            this.nudAdet.TabIndex = 66;
            this.nudAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnToplamTutarHesapla
            // 
            this.btnToplamTutarHesapla.Location = new System.Drawing.Point(491, 233);
            this.btnToplamTutarHesapla.Name = "btnToplamTutarHesapla";
            this.btnToplamTutarHesapla.Size = new System.Drawing.Size(104, 35);
            this.btnToplamTutarHesapla.TabIndex = 65;
            this.btnToplamTutarHesapla.Text = "Toplam Tutar Hesapla";
            this.btnToplamTutarHesapla.UseVisualStyleBackColor = true;
            this.btnToplamTutarHesapla.Click += new System.EventHandler(this.btnToplamTutarHesapla_Click);
            // 
            // labelToplamTutar
            // 
            this.labelToplamTutar.AutoSize = true;
            this.labelToplamTutar.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelToplamTutar.Location = new System.Drawing.Point(298, 244);
            this.labelToplamTutar.Name = "labelToplamTutar";
            this.labelToplamTutar.Size = new System.Drawing.Size(89, 16);
            this.labelToplamTutar.TabIndex = 64;
            this.labelToplamTutar.Text = "Toplam Tutar:";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.Location = new System.Drawing.Point(396, 244);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(49, 13);
            this.lblToplam.TabIndex = 63;
            this.lblToplam.Text = "              ";
            // 
            // labelSepet
            // 
            this.labelSepet.AutoSize = true;
            this.labelSepet.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSepet.Location = new System.Drawing.Point(298, 18);
            this.labelSepet.Name = "labelSepet";
            this.labelSepet.Size = new System.Drawing.Size(57, 18);
            this.labelSepet.TabIndex = 62;
            this.labelSepet.Text = "SEPET\r\n";
            // 
            // lbSepet
            // 
            this.lbSepet.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSepet.FormattingEnabled = true;
            this.lbSepet.ItemHeight = 14;
            this.lbSepet.Location = new System.Drawing.Point(295, 40);
            this.lbSepet.Name = "lbSepet";
            this.lbSepet.Size = new System.Drawing.Size(300, 186);
            this.lbSepet.TabIndex = 61;
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.Enabled = false;
            this.btnSepeteEkle.Location = new System.Drawing.Point(149, 355);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(101, 26);
            this.btnSepeteEkle.TabIndex = 60;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = true;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // labelTutar
            // 
            this.labelTutar.AutoSize = true;
            this.labelTutar.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTutar.Location = new System.Drawing.Point(18, 361);
            this.labelTutar.Name = "labelTutar";
            this.labelTutar.Size = new System.Drawing.Size(42, 16);
            this.labelTutar.TabIndex = 59;
            this.labelTutar.Text = "Tutar:";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(149, 319);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(101, 29);
            this.btnHesapla.TabIndex = 58;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // labelAdet
            // 
            this.labelAdet.AutoSize = true;
            this.labelAdet.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAdet.Location = new System.Drawing.Point(18, 328);
            this.labelAdet.Name = "labelAdet";
            this.labelAdet.Size = new System.Drawing.Size(37, 16);
            this.labelAdet.TabIndex = 57;
            this.labelAdet.Text = "Adet:";
            // 
            // lbUrunler
            // 
            this.lbUrunler.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbUrunler.FormattingEnabled = true;
            this.lbUrunler.ItemHeight = 14;
            this.lbUrunler.Location = new System.Drawing.Point(15, 40);
            this.lbUrunler.Name = "lbUrunler";
            this.lbUrunler.Size = new System.Drawing.Size(235, 256);
            this.lbUrunler.TabIndex = 56;
            this.lbUrunler.SelectedIndexChanged += new System.EventHandler(this.lbUrunler_SelectedIndexChanged);
            // 
            // labelUrunler
            // 
            this.labelUrunler.AutoSize = true;
            this.labelUrunler.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUrunler.Location = new System.Drawing.Point(16, 18);
            this.labelUrunler.Name = "labelUrunler";
            this.labelUrunler.Size = new System.Drawing.Size(82, 18);
            this.labelUrunler.TabIndex = 55;
            this.labelUrunler.Text = "ÜRÜNLER";
            // 
            // btnDukkanIslemleri
            // 
            this.btnDukkanIslemleri.Location = new System.Drawing.Point(295, 362);
            this.btnDukkanIslemleri.Name = "btnDukkanIslemleri";
            this.btnDukkanIslemleri.Size = new System.Drawing.Size(150, 37);
            this.btnDukkanIslemleri.TabIndex = 74;
            this.btnDukkanIslemleri.Text = "Dükkan İşlemleri";
            this.btnDukkanIslemleri.UseVisualStyleBackColor = true;
            this.btnDukkanIslemleri.Click += new System.EventHandler(this.btnDukkanIslemleri_Click);
            // 
            // btnYeniSatisIslemi
            // 
            this.btnYeniSatisIslemi.Location = new System.Drawing.Point(491, 364);
            this.btnYeniSatisIslemi.Name = "btnYeniSatisIslemi";
            this.btnYeniSatisIslemi.Size = new System.Drawing.Size(104, 36);
            this.btnYeniSatisIslemi.TabIndex = 75;
            this.btnYeniSatisIslemi.Text = "Yeni Satış İşlemi";
            this.btnYeniSatisIslemi.UseVisualStyleBackColor = true;
            this.btnYeniSatisIslemi.Click += new System.EventHandler(this.btnYeniSatisIslemi_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(610, 410);
            this.Controls.Add(this.btnYeniSatisIslemi);
            this.Controls.Add(this.btnDukkanIslemleri);
            this.Controls.Add(this.label);
            this.Controls.Add(this.lblIndirimliTutar);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.labelOdeme);
            this.Controls.Add(this.rbKrediKarti);
            this.Controls.Add(this.rbNakit);
            this.Controls.Add(this.btnSiparişOnay);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.btnToplamTutarHesapla);
            this.Controls.Add(this.labelToplamTutar);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.labelSepet);
            this.Controls.Add(this.lbSepet);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.labelTutar);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.labelAdet);
            this.Controls.Add(this.lbUrunler);
            this.Controls.Add(this.labelUrunler);
            this.Name = "Form3";
            this.Text = "SATIŞ İŞLEMLERİ";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblIndirimliTutar;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label labelOdeme;
        private System.Windows.Forms.RadioButton rbKrediKarti;
        private System.Windows.Forms.RadioButton rbNakit;
        private System.Windows.Forms.Button btnSiparişOnay;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.Button btnToplamTutarHesapla;
        private System.Windows.Forms.Label labelToplamTutar;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label labelSepet;
        private System.Windows.Forms.ListBox lbSepet;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.Label labelTutar;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label labelAdet;
        private System.Windows.Forms.ListBox lbUrunler;
        private System.Windows.Forms.Label labelUrunler;
        private System.Windows.Forms.Button btnDukkanIslemleri;
        private System.Windows.Forms.Button btnYeniSatisIslemi;
    }
}