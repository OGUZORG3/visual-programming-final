using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Final_Proje.islevFormları
{
    public partial class AracDuzenle : Form
    {
        MysqlBaglantı baglantı = new MysqlBaglantı();
        Formlar.Araclar baglıEkran;
        public AracDuzenle(Formlar.Araclar parametre,Arac arac)
        {
            InitializeComponent();
            baglıEkran = parametre;
            txtMarka.Text = arac.marka;
            txtModel.Text = arac.model;
            txtSaseNo.Text = arac.saseno;
            txtYıl.Text = arac.yil;
            TxtPlaka.Text = arac.plaka;
            cmbFiloİd.Text = Convert.ToString(arac.filoid);
            cmbSigortaİd.Text = Convert.ToString(arac.sigortaid);
        }
        private void Filo()
        {

            cmbFiloİd.Items.Clear();
            string sql = "SELECT filo_id FROM filolar";
            baglantı.komut = new MySqlCommand(sql, baglantı.mysqlbaglan);
            baglantı.oku = baglantı.komut.ExecuteReader();
            while (baglantı.oku.Read())
            {
                cmbFiloİd.Items.Add(baglantı.oku[0]);
            }
            baglantı.oku.Close();

            baglıEkran.yenile();
        }
        private void sigorta()
        {

            cmbSigortaİd.Items.Clear();
            string sql = "SELECT sigorta_id FROM sigorta_sirketleri";
            baglantı.komut = new MySqlCommand(sql, baglantı.mysqlbaglan);
            baglantı.oku = baglantı.komut.ExecuteReader();
            while (baglantı.oku.Read())
            {
                cmbSigortaİd.Items.Add(baglantı.oku[0]);
            }
            baglantı.oku.Close();

            baglıEkran.yenile();
        }
        private void AracDuzenle_Load(object sender, EventArgs e)
        {
            baglantı.BaglantıAc();
            sigorta();
            Filo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Arac arac = new Arac(txtMarka.Text, txtModel.Text,txtYıl.Text, txtSaseNo.Text, TxtPlaka.Text, Convert.ToInt32(cmbSigortaİd.Text), Convert.ToInt32(cmbFiloİd.Text));
            baglıEkran.AracDuzenle(arac);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
