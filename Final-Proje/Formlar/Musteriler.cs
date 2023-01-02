using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Final_Proje.Formlar
{
    public partial class Musteriler : Form
    {
        MysqlBaglantı baglantı = new MysqlBaglantı();
        İslemler islemYap = new İslemler();

        public Musteriler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            islevFormları.MusteriEkle me = new islevFormları.MusteriEkle(this);
            me.Show();
        }

        private void Musteriler_Load(object sender, EventArgs e)
        {
            
            btnMusteriEkle.DataSource = islemYap.Listele("musteriler");
        }

        public void yenile()
        {
            btnMusteriEkle.DataSource = islemYap.Listele("musteriler");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            islemYap.Sil(index, "musteriler", "musteri_id");
            yenile();
        }
        public string index;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index = btnMusteriEkle.Rows[e.RowIndex].Cells[0].Value.ToString();
            ad = btnMusteriEkle.Rows[e.RowIndex].Cells[1].Value.ToString();
            soyad = btnMusteriEkle.Rows[e.RowIndex].Cells[2].Value.ToString();
            tel = btnMusteriEkle.Rows[e.RowIndex].Cells[5].Value.ToString();
            tc = btnMusteriEkle.Rows[e.RowIndex].Cells[3].Value.ToString();
            adres = btnMusteriEkle.Rows[e.RowIndex].Cells[4].Value.ToString();
            aracid = Convert.ToInt32(btnMusteriEkle.Rows[e.RowIndex].Cells[6].Value);
            sigortaid = Convert.ToInt32(btnMusteriEkle.Rows[e.RowIndex].Cells[7].Value);
            filoid = Convert.ToInt32(btnMusteriEkle.Rows[e.RowIndex].Cells[8].Value);
            }
            catch (Exception)
            {
            }
        }
        
            string ad, soyad,tel,tc,adres;
            int aracid, sigortaid, filoid;
        private void button2_Click(object sender, EventArgs e)
        {
            if (index !=null)
            {
            Musteri musteri =  new Musteri(ad,soyad,tel,tc,adres,aracid ,sigortaid,filoid);
            islevFormları.MusteriDuzenle musteriDuzenle = new islevFormları.MusteriDuzenle(this, musteri);
            musteriDuzenle.Show();

            }
            else
            {
                MessageBox.Show(" Musteri secmediniz");
            }
        }
        
        public void musteriDuzenle(Musteri musteri)
        {
            baglantı.BaglantıAc();
            baglantı.komut = new MySqlCommand("UPDATE musteriler set ad=@ad,soyad=@soyad,tc=@tc,adres=@adres,tel=@tel,arac_id=@arac_id,sigorta_id=@sigorta_id,filo_id=@filo_id Where musteri_id="+index+"", baglantı.mysqlbaglan);
            baglantı.komut.Parameters.AddWithValue("@ad", musteri.Ad);
            baglantı.komut.Parameters.AddWithValue("@soyad", musteri.SoyAd);
            baglantı.komut.Parameters.AddWithValue("@tc", musteri.Tc);
            baglantı.komut.Parameters.AddWithValue("@adres", musteri.Adres);
            baglantı.komut.Parameters.AddWithValue("@tel", musteri.Telefon);
            baglantı.komut.Parameters.AddWithValue("@arac_id", musteri.Aracİd);
            baglantı.komut.Parameters.AddWithValue("@sigorta_id", musteri.Sigortaİd);
            baglantı.komut.Parameters.AddWithValue("@filo_id", musteri.Filoİd);
            baglantı.komut.ExecuteNonQuery();
            yenile();
            baglantı.BaglantıKapat();


        }
    }
}
