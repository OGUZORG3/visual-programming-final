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
    public partial class FiloDuzenle : Form
    {
        Formlar.Filolar baglıEkran;
        public FiloDuzenle(Formlar.Filolar parametre,Filo filo)
        {
            InitializeComponent();
            baglıEkran = parametre;
            txtFiloid.Text = Convert.ToString(filo.filono);
            txtFiloadı.Text = filo.filoadi; 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Filo filo = new Filo(Convert.ToInt32(txtFiloid.Text), txtFiloadı.Text);
            baglıEkran.filoGuncelle(filo);
            baglıEkran.yenile();
            this.Close();
        }
    }
}
