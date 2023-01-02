using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Proje
{
    public class Arac
    {
        public string marka;
        public string model;
        public string yil;
        public string saseno;
        public string plaka;
        public int sigortaid, filoid;
        public Arac(string Marka, string Model, string Yil, string Sase, string Plaka, int Sigorta, int Filo)
        {
            marka = Marka;
            model = Model;
            yil = Yil;
            saseno = Sase;
            plaka = Plaka;
            sigortaid = Sigorta;
            filoid = Filo;
        }
    }
}
