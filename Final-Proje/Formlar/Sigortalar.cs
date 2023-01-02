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
    public partial class Sigortalar : Form
    {
        İslemler islemYap = new İslemler();
        MysqlBaglantı baglantı = new MysqlBaglantı();
        public Sigortalar()
        {
            InitializeComponent();
        }
        
        private void btnSigortaEkle_Click(object sender, EventArgs e)
        {
            islevFormları.SigortaEkle sigortaEkle = new islevFormları.SigortaEkle(this);
            sigortaEkle.Show();
        }

        private void Sigortalar_Load(object sender, EventArgs e)
        {
            sigortaTablo.DataSource = islemYap.Listele("sigorta_sirketleri");
        }
        public void yenile()
        {
            sigortaTablo.DataSource = islemYap.Listele("sigorta_sirketleri");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            islemYap.Sil(index, "sigorta_sirketleri", "sigorta_id");
            yenile();
        }
        public string index;
        private void sigortaTablo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index = sigortaTablo.Rows[e.RowIndex].Cells[0].Value.ToString();
                sigortadi= sigortaTablo.Rows[e.RowIndex].Cells[2].Value.ToString();
                sigortaid= Convert.ToInt32(sigortaTablo.Rows[e.RowIndex].Cells[1].Value);
            }
            catch (Exception)
            {
            }
        }
        public string sigortadi;
        public int sigortaid;
        private void btnSigortaGüncelle_Click(object sender, EventArgs e)
        {
            if (index!=null)
            {
            Sigorta sigorta = new Sigorta(sigortadi,sigortaid);
            islevFormları.SigortaDuzenle sigortaDuzenle = new islevFormları.SigortaDuzenle(this,sigorta);
            sigortaDuzenle.Show();
            }
            else
            {
                MessageBox.Show("sigorta secmediniz");
            }
        }
        public void sigortaDuzenle(Sigorta sigorta)
        {
            baglantı.BaglantıAc();
            baglantı.komut = new MySqlCommand("UPDATE sigorta_sirketleri set Sigorta_adi=@sigorta_adi,sigorta_no=@sigorta_no Where sigorta_id=" + index + "", baglantı.mysqlbaglan);
            baglantı.komut.Parameters.AddWithValue("@sigorta_adi", sigorta.sigortadi);
            baglantı.komut.Parameters.AddWithValue("@sigorta_no", sigorta.sigortano);
            baglantı.komut.ExecuteNonQuery();
            yenile();
            baglantı.BaglantıKapat();
        }
    }
}
