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
    
    public partial class İslem : Form
    {
        İslemler islemyap = new İslemler();
        MysqlBaglantı veri = new MysqlBaglantı();
        
        public İslem()
        {
            InitializeComponent();
        }

        private void İslem_Load(object sender, EventArgs e)
        {
            veri.BaglantıAc();
            arac();
            parca();
            islem();
            dataislem.DataSource = islemyap.Listele("gecmis");
            dataracfiyat.DataSource = islemyap.FiyatListele("gecmis");
        }
        private void arac()
        {

            cmbAracid.Items.Clear();
            string sql = "SELECT * FROM araclar";
            veri.komut = new MySqlCommand(sql, veri.mysqlbaglan);
            veri.oku = veri.komut.ExecuteReader();
            while (veri.oku.Read())
            {
                cmbAracid.Items.Add((veri.oku[0].ToString() + " " + veri.oku[1].ToString() + " " + veri.oku[2]));
            }
            veri.oku.Close();

        }
        private void parca()
        {

            cmbparca.Items.Clear();
            string sql = "SELECT * FROM yedekparca";
            veri.komut = new MySqlCommand(sql, veri.mysqlbaglan);
            veri.oku = veri.komut.ExecuteReader();
            while (veri.oku.Read())
            {
                cmbparca.Items.Add(veri.oku[1].ToString()+":"+veri.oku[2]);
            }
            veri.oku.Close();

        }
        private void islem()
        {

            cmbislem.Items.Clear();
            string sql = "SELECT * FROM islem";
            veri.komut = new MySqlCommand(sql, veri.mysqlbaglan);
            veri.oku = veri.komut.ExecuteReader();
            while (veri.oku.Read())
            {
                cmbislem.Items.Add(veri.oku[1].ToString() + ":" + veri.oku[2]);
            }
            veri.oku.Close();

        }
        int a=0, b=0;
        private void cmbparca_SelectedIndexChanged(object sender, EventArgs e)
        {           
            a=hesapla(cmbparca.Text);
            label4.Text = Convert.ToString(a+b);
        }

        private void cmbislem_SelectedIndexChanged(object sender, EventArgs e)
        {
            b = hesapla(cmbislem.Text);
            label4.Text = Convert.ToString(b+a);
        }

        private void btnaracekle_Click(object sender, EventArgs e)
        {
            Yapılanislem islem = new Yapılanislem(cmbAracid.Text,cmbparca.Text,cmbislem.Text,label4.Text);
            islemyap.İslemekle(islem);
            label4.Text = "";
            cmbislem.Text = "";
            cmbparca.Text = "";
            dataislem.DataSource = islemyap.Listele("gecmis");
            dataracfiyat.DataSource = islemyap.FiyatListele("gecmis");

        }
        string index;
        private void dataislem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index = dataislem.Rows[e.RowIndex].Cells[0].Value.ToString();          }
            catch (Exception)
            {
            }
        }

       

        private void btnislemsil_Click_1(object sender, EventArgs e)
        {
            islemyap.Sil(index, "gecmis", "gecmisislem_id");
            dataislem.DataSource = islemyap.Listele("gecmis");
        }
      

        public int hesapla(string sayı1)
        {
            char[] ayrac = { ':' };
            string kelime = sayı1;
            string[] parcalar = kelime.Split(ayrac);
            return  Convert.ToInt32(parcalar[1]);
            
        }
    }
}
