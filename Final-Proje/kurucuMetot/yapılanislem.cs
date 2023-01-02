using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Proje
{
     public class Yapılanislem
    {
        public string arac_id;
        public string parca;
        public string islem;
        public string bedel;
        public Yapılanislem(string Arac_İd,string Parca,string İslem,string Bedel)
        {
            arac_id = Arac_İd;
            parca = Parca;
            islem = İslem;
            bedel = Bedel;
        }
    }
}
