using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Final_Proje.islevFormları
{
    public partial class SigortaEkle : Form
    {
        Formlar.Sigortalar baglıEkran;
        public SigortaEkle(Formlar.Sigortalar parametre)
        {
            InitializeComponent();
            baglıEkran = parametre;
        }

        private void SigortaEkle_Load(object sender, EventArgs e)
        {

        }
        MysqlBaglantı veri = new MysqlBaglantı();
        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {

            veri.BaglantıAc();
            veri.komut = new MySqlCommand("INSERT INTO sigorta_sirketleri (sigorta_adi,sigorta_no)values(@sigorta_adi,@sigorta_no)", veri.mysqlbaglan);
                veri.komut.Parameters.AddWithValue("@sigorta_no", txtSigortaid.Text);
            veri.komut.Parameters.AddWithValue("@sigorta_adi", txtSigotadı.Text);
            veri.komut.ExecuteNonQuery();
            veri.BaglantıKapat();
                baglıEkran.yenile();
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show("" + hata);
                throw;
            }
            finally
            {
                System.Windows.Forms.MessageBox.Show("Kayıt İşlemi Başarılı");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
