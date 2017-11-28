using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev21_12
{
    public partial class Form4 : Form
    {
       
        
        
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)

        {   
        
            foreach (Urun u in Form3.UrunKatalogu.Dukkanimiz.UrunlerListesi)
            {
                lbUrunKatalogu.Items.Add(u);
            }
            lblSatoktakiUrunSayisi.Text = Form3.HesapDefteri.ToplamUrunAdedi.ToString();
            lblToplamSatisTutari.Text = Form3.ToplamSatisTutari.ToString();          
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            tabControlDukkanIslemleri.SelectedTab = tabPageUrunEkle;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtUrunAdi.Text =="" || txtUrunFiyati.Text=="" || txtUrunKodu.Text=="" || cmbUrunTanimi.Text=="" || nudUrunAdedi.Value==0)
            {
                MessageBox.Show("Bu alanlar boş bırakılamaz.");
            }
            else
            {
                Urun EklenecekUrun = new Urun();
                bool x = true;
                foreach (Urun u in Form3.UrunKatalogu.Dukkanimiz.UrunlerListesi)
                {
                    if (u.Tanım.UrunKodu == Convert.ToInt32(txtUrunKodu.Text))
                    {
                        lblEklenenUrun.Text = "Bu kodda ürün vardır.";
                        x = false;

                    }

                }

                if (x == true)
                {
                    EklenecekUrun.Tanım.Ad = txtUrunAdi.Text;
                    EklenecekUrun.Tanım.Fiyatı = Convert.ToDecimal(txtUrunFiyati.Text);
                    EklenecekUrun.Tanım.UrunAdet = Convert.ToInt32(nudUrunAdedi.Value);
                    EklenecekUrun.Tanım.UrunKodu = Convert.ToInt32(txtUrunKodu.Text);
                    EklenecekUrun.Tanım.Tanım = cmbUrunTanimi.Text;
                    Form3.UrunKatalogu.Dukkanimiz.UrunEkle(EklenecekUrun);

                    lblEklenenUrun.Text = EklenecekUrun.Tanım.UrunKodu.ToString() + " - " + EklenecekUrun.Tanım.Ad + " Ürünü eklenmiştir. ";
                    lbUrunKatalogu.Items.Clear();
                    foreach (Urun u in Form3.UrunKatalogu.Dukkanimiz.UrunlerListesi)
                    {
                        lbUrunKatalogu.Items.Add(u);
                    }
                    Form3.HesapDefteri.stoksifirla();
                    lblSatoktakiUrunSayisi.Text = Form3.HesapDefteri.ToplamUrunAdedi.ToString();
                }


            }
           



            

        }

        private void btnHesapDefteriGoruntule_Click(object sender, EventArgs e)
        {
            tabControlDukkanIslemleri.SelectedTab = tabPageHesapDefteri;
          

            
        }

       

        private void btnHesapdefteriGoster_Click(object sender, EventArgs e)
        {
            tabControlDukkanIslemleri.SelectedTab = tabPageHesapDefteri;
            
          
        }

        private void lbUrunKatalogu_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbUrunKatalogu.SelectedItem = null;
        }

        private void btnSatisIslemleriGecis_Click(object sender, EventArgs e)
        {
            Form3.GeciciTutar = 0;

            if (Application.OpenForms[0] == this)
            {
                Application.Restart();
            }
            else
            {
                Form3 f = new Form3();
                f.Show();
                this.Close();
            }
        }

        private void txtUrunFiyati_TextChanged(object sender, EventArgs e)
        {
            if (txtUrunFiyati.Text ==0.ToString())
            {
                MessageBox.Show("Girilen bilgiler geçerli değil.");
            }

        }

        private void txtUrunKodu_TextChanged(object sender, EventArgs e)
        {
            if (txtUrunKodu.Text == 0.ToString())
            {
                MessageBox.Show("Girilen bilgiler geçerli değil.");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if ( txtStokUrunKodu.Text == "" || nudStokUrunAdedi.Value == 0)
            {
                MessageBox.Show("Bu alanlar boş bırakılamaz.");
            }
            else
            {
                Urun GuncellenenUrun = new Urun();
                bool x = true;
                foreach (Urun u in Form3.UrunKatalogu.Dukkanimiz.UrunlerListesi)
                {
                    if (u.Tanım.UrunKodu == Convert.ToInt32(txtStokUrunKodu.Text))
                    {

                       GuncellenenUrun.Tanım.UrunAdet = Convert.ToInt32(nudStokUrunAdedi.Value);
                       GuncellenenUrun.Tanım.UrunKodu = Convert.ToInt32(txtStokUrunKodu.Text);
                       Form3.UrunKatalogu.Dukkanimiz.UrunEkle(GuncellenenUrun);
                       lblGuncellenenUrun.Text = u.Tanım.UrunKodu.ToString() + " - " + u.Tanım.Ad + " Ürününün adedi\n            " 
                           + (u.Tanım.UrunAdet - nudStokUrunAdedi.Value).ToString()
                           + "+" + nudStokUrunAdedi.Value.ToString() + "=" + u.Tanım.UrunAdet.ToString()
                           + "\n     şeklinde güncellenmiştir. ";
                      
                       
                       Form3.HesapDefteri.stoksifirla();
                       lblSatoktakiUrunSayisi.Text = Form3.HesapDefteri.ToplamUrunAdedi.ToString();
                       x = false;
                    }

                }

                if (x == true)
                {
                    MessageBox.Show("Bu ürün stokta mevcut değildir lütfen ekleyiniz.");
                }


            }
        }

        private void btnHesapDefteri_Click(object sender, EventArgs e)
        {
            tabControlDukkanIslemleri.SelectedTab = tabPageHesapDefteri;
        }

        private void btnKasiyerEkle_Click(object sender, EventArgs e)
        {
            Form1.yeniKasiyer.KisiBilgisiDoldur(txtEklenenKasiyerAd.Text, txtEklenenKasiyerSoyadi.Text, txtEklenenSigortaNo.Text);
            lblEklenenKasiyer.Text = "Yeni Kasiyer eklenmiştir";
        }
    }
}
