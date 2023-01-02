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
    public partial class MusteriDuzenle : Form
    {
        MysqlBaglantı baglantı = new MysqlBaglantı();
        Formlar.Musteriler baglıEkran;
        public MusteriDuzenle(Formlar.Musteriler parametre, Musteri musteri)
        {
            baglantı.BaglantıAc();
            InitializeComponent();
            baglıEkran = parametre;
            txtAd.Text = musteri.Ad;
            txtSoyad.Text = musteri.SoyAd;
            txtTc.Text = musteri.Tc;
            txtTel.Text = musteri.Telefon;
            TxtAdres.Text = musteri.Adres;
            cmbAracid.Text=Convert.ToString(musteri.Aracİd);
            cmbFiloid.Text=Convert.ToString(musteri.Filoİd);
            cmbSigortaid.Text = Convert.ToString(musteri.Sigortaİd);

        }

        private void btnmusteriDuzenle_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri(txtAd.Text, txtSoyad.Text, txtTc.Text, txtTel.Text, TxtAdres.Text, Convert.ToInt32(cmbAracid.Text), Convert.ToInt32(cmbSigortaid.Text), Convert.ToInt32(cmbFiloid.Text));
            baglıEkran.musteriDuzenle(musteri);
            this.Close();
        }
        private void Arac()
        {
            
            cmbAracid.Items.Clear();
            string sql = "SELECT arac_id FROM araclar";
            baglantı.komut = new MySqlCommand(sql, baglantı.mysqlbaglan);
            baglantı.oku = baglantı.komut.ExecuteReader();
            while (baglantı.oku.Read())
            {
                cmbAracid.Items.Add(baglantı.oku[0]);
            }
            baglantı.oku.Close();

            baglıEkran.yenile();
        }
        private void Filo()
        {

            cmbFiloid.Items.Clear();
            string sql = "SELECT filo_id FROM filolar";
            baglantı.komut = new MySqlCommand(sql,baglantı.mysqlbaglan);
            baglantı.oku = baglantı.komut.ExecuteReader();
            while (baglantı.oku.Read())
            {
                cmbFiloid.Items.Add(baglantı.oku[0]);
            }
            baglantı.oku.Close();

            
        }
        private void Sigorta()
        {

            cmbSigortaid.Items.Clear();
            string sql = "SELECT sigorta_id FROM sigorta_sirketleri";
            baglantı.komut = new MySqlCommand(sql, baglantı.mysqlbaglan);
            baglantı.oku = baglantı.komut.ExecuteReader();
            while (baglantı.oku.Read())
            {
                cmbSigortaid.Items.Add(baglantı.oku[0]);
            }
            baglantı.oku.Close();

            
        }
        private void MusteriDuzenle_Load(object sender, EventArgs e)
        {
            Filo();
            Arac();
            Sigorta();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
