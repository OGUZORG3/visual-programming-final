using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Proje
{

    public class Musteri
    {
        public string Ad;
        public string SoyAd;
        public string Telefon;
        public string Tc;
        public string Adres;
        public int Aracİd;
        public int Sigortaİd;
        public int Filoİd;
        public Musteri(string ad, string Soyad,string Tel,string tc,string adres,int aracid,int sigortaid,int filoid)
        {
            Ad = ad;
            SoyAd = Soyad;
            Telefon = Tel;
            Tc = tc;
            Adres = adres;
            Aracİd = aracid;
            Sigortaİd = sigortaid;
            Filoİd = filoid;
        }
        
    }

}

