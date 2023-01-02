using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Proje.islevFormları
{
    public partial class SigortaDuzenle : Form
    {
        Formlar.Sigortalar baglıEkran;
        public SigortaDuzenle(Formlar.Sigortalar parametre,Sigorta sigorta)
        {
            baglıEkran = parametre;
            InitializeComponent();
            txtSigortaid.Text = Convert.ToString(sigorta.sigortano);
            txtSigotadı.Text = sigorta.sigortadi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sigorta sigorta = new Sigorta(txtSigotadı.Text,Convert.ToInt32(txtSigortaid.Text));
            baglıEkran.sigortaDuzenle(sigorta);
        }
    }
}
