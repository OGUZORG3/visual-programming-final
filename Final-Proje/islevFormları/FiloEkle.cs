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
    public partial class FiloEkle : Form
    {
        MysqlBaglantı veri = new MysqlBaglantı();
        Formlar.Filolar baglıEkran;
        public FiloEkle(Formlar.Filolar parametre)
        {
            InitializeComponent();
            baglıEkran = parametre;
        }

        private void FiloEkle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                veri.BaglantıAc();
                veri.komut = new MySqlCommand("INSERT INTO filolar (filo_adi,filo_no)values(@filo_adi,@filo_no)", veri.mysqlbaglan);
                veri.komut.Parameters.AddWithValue("@filo_no", txtFiloid.Text);
                veri.komut.Parameters.AddWithValue("@filo_adi", txtFiloadı.Text);
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
    }
}
