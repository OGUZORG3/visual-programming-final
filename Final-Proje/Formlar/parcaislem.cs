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
    public partial class parcaislem : Form
    {
        MysqlBaglantı veri = new MysqlBaglantı();
        İslemler islemyap = new İslemler();
        public parcaislem()
        {
            InitializeComponent();
        }

        private void btnAracekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtparcaisim.Text != string.Empty && txtparcafiyat.Text != string.Empty)
                {
                veri.BaglantıAc();
                veri.komut = new MySqlCommand("INSERT INTO yedekparca (parca_isim,parca_fiyat)values(@parcaisim,@parcafiyat)", veri.mysqlbaglan);
                veri.komut.Parameters.AddWithValue("@parcaisim",txtparcaisim.Text );
                veri.komut.Parameters.AddWithValue("@parcafiyat", txtparcafiyat.Text);
                veri.komut.ExecuteNonQuery();
                veri.BaglantıKapat();
                dataparca.DataSource = islemyap.Listele("yedekparca");

                }
                else
                {
                    MessageBox.Show("boş değer girdiniz");
                }
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show("" + hata);
                throw;
            }
            txtparcafiyat.Clear();
            txtparcaisim.Clear();
        }

        private void parcaislem_Load(object sender, EventArgs e)
        {
            dataparca.DataSource = islemyap.Listele("yedekparca");
            dataislem.DataSource = islemyap.Listele("islem");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtislemfiyat.Text!=string.Empty&&txtislemisim.Text!=string.Empty)
                {
                veri.BaglantıAc();
                veri.komut = new MySqlCommand("INSERT INTO islem (islem_isim,islem_fiyat)values(@islemisim,@islemfiyat)", veri.mysqlbaglan);
                veri.komut.Parameters.AddWithValue("@islemisim", txtislemisim.Text);
                veri.komut.Parameters.AddWithValue("@islemfiyat", txtislemfiyat.Text);
                veri.komut.ExecuteNonQuery();
                veri.BaglantıKapat();
                dataislem.DataSource = islemyap.Listele("islem");

                }
                else
                {
                    MessageBox.Show("boş değer girdiniz");
                }
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show("" + hata);
                throw;
            }
            txtislemfiyat.Clear();
            txtislemisim.Clear();
        }
        string parcaindex,islemindex;
        private void dataparca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                parcaindex = dataparca.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void btnislemsil_Click(object sender, EventArgs e)
        {
            islemyap.Sil(islemindex, "islem", "islem_id");
            dataislem.DataSource = islemyap.Listele("islem");
        }

        private void btnparcasil_Click(object sender, EventArgs e)
        {
            islemyap.Sil(parcaindex, "yedekparca", "parca_id");
            dataparca.DataSource = islemyap.Listele("yedekparca");
        }

        private void dataislem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                islemindex = dataislem.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (Exception)
            {
            }
        }
    }
}
