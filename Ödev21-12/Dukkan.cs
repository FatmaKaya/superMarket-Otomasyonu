using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev21_12
{
    public class Dukkan
    {
        public List<Urun> UrunlerListesi { get; set; }
        public Terminal Terminal1 = new Terminal();
        public string DukkanAdi { get; set; }
        public string DukkanAdresi { get; set; }

        
        public void UrunEkle(Urun u)
        {
            
           
            
            bool x = true;
           foreach (Urun ur in UrunlerListesi)
            {
               
                if (ur.Tanım.UrunKodu == u.Tanım.UrunKodu)
                {
                    x = false;
                    ur.Tanım.UrunAdet = ur.Tanım.UrunAdet + u.Tanım.UrunAdet;
                }
               
            }

           
            if(x==true)
            {
                UrunlerListesi.Add(u);
                x = true;

            }

            
        }
     
        public void UrunCikar(Urun u )
        {   
             
            bool x = true;
            
            foreach (Urun ur in UrunlerListesi)
            {
                
               
                if (ur.Tanım.UrunKodu == u.Tanım.UrunKodu)
                {
                    x = false;
                    ur.Tanım.UrunAdet = ur.Tanım.UrunAdet - u.Tanım.Miktar;
                }

            }


            if (x == true)
            {
                UrunlerListesi.Remove(u);
                x = true;

            }
            
        }
         public  string UrunListele()
         {
             string mesaj = "";
             foreach (Urun u in UrunlerListesi)
             {
                 {
                     mesaj += "\n Ürün Kodu: " + u.Tanım.UrunKodu.ToString() +
                              " Ürün Adı: " + u.Tanım.Ad+
                              " Ürün Fiyatı: " + u.Tanım.Fiyatı.ToString();
                 }

             }
             return mesaj;
         }

        public Dukkan()
        {
            this.DukkanAdi = "3'LÜ MTOK KIZLAR MARKET";
            this.DukkanAdresi = "Acarlar Mah. Şehit Mahmut Tuğrul Sok. No : 16 Turgutlu/Manisa";
            this.Terminal1.SeriNo = 001;

            this.UrunlerListesi = new List<Urun>();
            Urun U1 = new Urun();
            Urun U2 = new Urun();
            Urun U3 = new Urun();
            Urun U4 = new Urun();
            Urun U5 = new Urun();
            Urun U6 = new Urun();
            Urun U7 = new Urun();
            Urun U8 = new Urun();
            Urun U9 = new Urun();
            Urun U10 = new Urun();
            Urun U11 = new Urun();
            Urun U12 = new Urun();
            Urun U13 = new Urun();
            Urun U14 = new Urun();
            Urun U15 = new Urun();


            U1.Tanım.UrunKodu = 001;
            U1.Tanım.Tanım = "Gıda";
            U1.Tanım.Ad = "Makarna";
            U1.Tanım.Fiyatı = 3;
            U1.Tanım.UrunAdet = 50;
            UrunlerListesi.Add(U1);

            U2.Tanım.UrunKodu = 002;
            U2.Tanım.Tanım = "Gıda";
            U2.Tanım.Ad = "Ekmek";
            U2.Tanım.Fiyatı = 1;
            U2.Tanım.UrunAdet = 12;
            UrunlerListesi.Add(U2);

            U3.Tanım.UrunKodu = 003;
            U3.Tanım.Tanım = "Bakım";
            U3.Tanım.Ad = "Krem";
            U3.Tanım.Fiyatı = 10;
            U3.Tanım.UrunAdet = 20;
            UrunlerListesi.Add(U3);

            U4.Tanım.UrunKodu = 004;
            U4.Tanım.Tanım = "Bakım";
            U4.Tanım.Ad = "Sabun";
            U4.Tanım.Fiyatı = 5.90M;
            U4.Tanım.UrunAdet = 5;
            UrunlerListesi.Add(U4);

            U5.Tanım.UrunKodu = 005;
            U5.Tanım.Tanım = "Elektronik";
            U5.Tanım.Ad = "Kulaklık";
            U5.Tanım.Fiyatı = 20;
            U5.Tanım.UrunAdet = 7;
            UrunlerListesi.Add(U5);

            U6.Tanım.UrunKodu = 006;
            U6.Tanım.Tanım = "Elektronik";
            U6.Tanım.Ad = "Şarj Aleti";
            U6.Tanım.Fiyatı = 50;
            U6.Tanım.UrunAdet = 6;
            UrunlerListesi.Add(U6);

            U7.Tanım.UrunKodu = 007;
            U7.Tanım.Tanım = "Gıda";
            U7.Tanım.Ad = "Cips";
            U7.Tanım.Fiyatı = 2.25M;
            U7.Tanım.UrunAdet = 30;
            UrunlerListesi.Add(U7);

            U8.Tanım.UrunKodu = 008;
            U8.Tanım.Tanım = "Gıda";
            U8.Tanım.Ad = "Jelibon";
            U8.Tanım.Fiyatı = 3.6M;
            U8.Tanım.UrunAdet = 5;
            UrunlerListesi.Add(U8);

            U9.Tanım.UrunKodu = 009;
            U9.Tanım.Tanım = "Gıda";
            U9.Tanım.Ad = "Meyve Suyu";
            U9.Tanım.Fiyatı = 0.75M;
            U9.Tanım.UrunAdet = 12;
            UrunlerListesi.Add(U9);

            U10.Tanım.UrunKodu = 010;
            U10.Tanım.Tanım = "Bakım";
            U10.Tanım.Ad = "Saç Kremi";
            U10.Tanım.Fiyatı = 7.85M;
            U10.Tanım.UrunAdet = 6;
            UrunlerListesi.Add(U10);

            U11.Tanım.UrunKodu = 011;
            U11.Tanım.Tanım = "Bakım";
            U11.Tanım.Ad = "Parfüm";
            U11.Tanım.Fiyatı = 35;
            U11.Tanım.UrunAdet = 5;
            UrunlerListesi.Add(U11);

            U12.Tanım.UrunKodu = 0012;
            U12.Tanım.Tanım = "Bakım";
            U12.Tanım.Ad = "Duş Jeli";
            U12.Tanım.Fiyatı = 10;
            U12.Tanım.UrunAdet = 20;
            UrunlerListesi.Add(U12);

            U13.Tanım.UrunKodu = 013;
            U13.Tanım.Tanım = "Elektronik";
            U13.Tanım.Ad = "Usb";
            U13.Tanım.Fiyatı = 34.99M;
            U13.Tanım.UrunAdet = 12;
            UrunlerListesi.Add(U13);

            U14.Tanım.UrunKodu = 014;
            U14.Tanım.Tanım = "Elektronik";
            U14.Tanım.Ad = "Saç Kurutma Makinesi";
            U14.Tanım.Fiyatı = 70;
            U14.Tanım.UrunAdet = 7;
            UrunlerListesi.Add(U14);

            U15.Tanım.UrunKodu = 015;
            U5.Tanım.Tanım = "Elektronik";
            U15.Tanım.Ad = "Vantilatör";
            U15.Tanım.Fiyatı = 120.85M;
            U15.Tanım.UrunAdet = 6;
            UrunlerListesi.Add(U15);
        }

    }
}
