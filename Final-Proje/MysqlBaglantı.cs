using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;


namespace Final_Proje
{
    class MysqlBaglantı
    {
        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=otoservis;Uid=root;Pwd='1234';");
        public MySqlDataReader oku;
        public MySqlCommand komut = new MySqlCommand();
        public MySqlDataAdapter adapter;
        public DataTable dataset;
        public void BaglantıAc()
        {
            try
            {
                if (mysqlbaglan.State == ConnectionState.Closed)
                {
                    mysqlbaglan.Open();
                }
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show("Veri tabanı ile bağlantı sağlanamadı\n" + hata);
                throw;
            }
        }
        public void BaglantıKapat()
        {
            try
            {
                if (mysqlbaglan.State == ConnectionState.Closed)
                {
                    mysqlbaglan.Close();
                }
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show("" + hata);
                throw;
            }
        }

    }
}
