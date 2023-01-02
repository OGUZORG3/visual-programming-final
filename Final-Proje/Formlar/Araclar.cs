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

namespace Final_Proje.Formlar
{
    public partial class Araclar : Form
    {
        MysqlBaglantı baglantı = new MysqlBaglantı();
        İslemler islemYap = new İslemler();
        public Araclar()
        {
            InitializeComponent();
         
        }

        private void btnAracekle_Click(object sender, EventArgs e)
        {
            islevFormları.AracEkle aracEkle = new islevFormları.AracEkle(this);
            aracEkle.Show();
        }
        İslemler ekle = new İslemler();
        private void Araclar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ekle.Listele("araclar");
        }
        public void yenile()
        {
            dataGridView1.DataSource = islemYap.Listele("araclar");
        }
      
        private void button3_Click(object sender, EventArgs e)
        {
            islemYap.Sil(index, "araclar", "arac_id");
            yenile();
        }
        public string index;
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            index = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            marka= dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            model = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            yil = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            sase_no = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            plaka = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            sigortaid=Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[6].Value);
                filod = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[7].Value);
            }
            catch (Exception)
            {

                
            }
        }
        string marka, model, plaka, sase_no,yil;
        int  sigortaid, filod;
        private void button2_Click(object sender, EventArgs e)
        {
            if (index!=null)
            {
            Arac arac = new Arac(marka, model, yil, sase_no, plaka, sigortaid, filod);
            islevFormları.AracDuzenle aracDuzenle = new islevFormları.AracDuzenle(this,arac);
            aracDuzenle.Show();

            }
            else
            {
                MessageBox.Show("Arac secmediniz");
            }
        }
        public void AracDuzenle (Arac arac)
        {
            baglantı.BaglantıAc();
            baglantı.komut = new MySqlCommand("UPDATE araclar set marka=@marka,model=@model,yil=@yil,sase_no=@sase_no,plaka=@plaka,sigorta_id=@sigorta_id,filo_id=@filo_id Where arac_id=" + index + "", baglantı.mysqlbaglan);
            baglantı.komut.Parameters.AddWithValue("@marka", arac.marka);
            baglantı.komut.Parameters.AddWithValue("@model", arac.model);
            baglantı.komut.Parameters.AddWithValue("@yil", arac.yil);
            baglantı.komut.Parameters.AddWithValue("@sase_no", arac.saseno);
            baglantı.komut.Parameters.AddWithValue("@plaka", arac.plaka);
            baglantı.komut.Parameters.AddWithValue("@sigorta_id", arac.sigortaid);
            baglantı.komut.Parameters.AddWithValue("@filo_id", arac.filoid);
            baglantı.komut.ExecuteNonQuery();
            yenile();
            
            baglantı.BaglantıKapat();
        }
    }
}
