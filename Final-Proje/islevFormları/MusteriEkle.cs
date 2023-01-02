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
    public partial class MusteriEkle : Form
    {
        Formlar.Musteriler baglıEkran;
        MysqlBaglantı veri = new MysqlBaglantı();
        public MusteriEkle(Formlar.Musteriler Parametre)
        {
            InitializeComponent();
            baglıEkran = Parametre;
            veri.BaglantıAc();
            
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtTc.TextLength<12 && txtTc.TextLength>10))
                {
                    if ((txtTel.TextLength < 13 && txtTel.TextLength > 11))
                    {
                        if (txtAd.Text!=string.Empty&&txtSoyad.Text!=string.Empty&&TxtAdres.Text!=string.Empty)
                        {
                            İslemler islemyap = new İslemler();
                            Musteri musteri = new Musteri(txtAd.Text, txtSoyad.Text, txtTel.Text, txtTc.Text, TxtAdres.Text, Convert.ToInt32(cmbAracid.Text), Convert.ToInt32(cmbSigortaid.Text), Convert.ToInt32(cmbFiloid.Text));
                            islemyap.musteriEkle(musteri);
                            baglıEkran.yenile();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("İsim , Soyisim ve Adres boş olamaz");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Telefon numarasının formatı yanlış");
                    }
                }
                else
                {
                    MessageBox.Show("Tc Kimlik numarasının formatı yanlış");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("derğerlerde boşluklar var");
            }
        }

        private void MusteriEkle_Load(object sender, EventArgs e)
        {
            arac();
            sigorta();
            Filo();
            
        }
        private void arac()
        {
            
            cmbAracid.Items.Clear();
            string sql = "SELECT arac_id FROM araclar";
            veri.komut = new MySqlCommand(sql, veri.mysqlbaglan);
            veri.oku = veri.komut.ExecuteReader();
            while (veri.oku.Read())
            {
                cmbAracid.Items.Add(veri.oku[0]);
            }
            veri.oku.Close();

            baglıEkran.yenile();
        }
        private void Filo()
        {
            
            cmbFiloid.Items.Clear();
            string sql = "SELECT filo_id FROM filolar";
            veri.komut = new MySqlCommand(sql, veri.mysqlbaglan);
            veri.oku = veri.komut.ExecuteReader();
            while (veri.oku.Read())
            {
                cmbFiloid.Items.Add(veri.oku[0]);
            }
            veri.oku.Close();

            baglıEkran.yenile();
        }
        private void sigorta()
        {
          
            cmbSigortaid.Items.Clear();
            string sql = "SELECT sigorta_id FROM sigorta_sirketleri";
            veri.komut = new MySqlCommand(sql, veri.mysqlbaglan);
            veri.oku = veri.komut.ExecuteReader();
            while (veri.oku.Read())
            {
                cmbSigortaid.Items.Add(veri.oku[0]);
            }
            veri.oku.Close();

            baglıEkran.yenile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
