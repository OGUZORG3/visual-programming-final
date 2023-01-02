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
    
    class İslemler
    {
        MysqlBaglantı veri = new MysqlBaglantı();
        public DataTable Listele(string tablo)
        {
            try
            {
                veri.dataset = new DataTable();
                veri.BaglantıAc();
                veri.adapter = new MySqlDataAdapter("SELECT * FROM "+tablo+" ", veri.mysqlbaglan);
                veri.adapter.Fill(veri.dataset);
                veri.mysqlbaglan.Close();
                return veri.dataset;
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show("" + hata);
                throw;
            }
        }
        public DataTable AracListele(string tablo)
        {
            try
            {
                veri.dataset = new DataTable();
                veri.BaglantıAc();
                veri.adapter = new MySqlDataAdapter("SELECT araclar.arac_id AS AracİD, araclar.marka,araclar.model,araclar.yil,araclar.plaka,araclar.sase_no AS SaseNO,sigorta_sirketleri.sigorta_adi,filolar.filo_adi FROM araclar INNER JOIN sigorta_sirketleri ON sigorta_sirketleri.sigorta_id = araclar.sigorta_id INNER JOIN filolar ON filolar.filo_id = araclar.filo_id ", veri.mysqlbaglan);
                veri.adapter.Fill(veri.dataset);
                veri.mysqlbaglan.Close();
                return veri.dataset;
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show("" + hata);
                throw;
            }

        }
        public DataTable FiyatListele(string tablo)
        {
            try
            {
                veri.dataset = new DataTable();
                veri.BaglantıAc();
                veri.adapter = new MySqlDataAdapter("SELECT arac_id,SUM(bedel) AS bedel FROM gecmis GROUP BY arac_id ORDER BY COUNT(arac_id) DESC ", veri.mysqlbaglan);
                veri.adapter.Fill(veri.dataset);
                veri.mysqlbaglan.Close();
                return veri.dataset;
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show("" + hata);
                throw;
            }
        }
        //SELECT arac_id,SUM(bedel) FROM gecmis GROUP BY arac_id ORDER BY COUNT(arac_id) DESC;
        public DataTable MusteriListele(string tablo)
        {
            try
            {
                veri.dataset = new DataTable();
                veri.BaglantıAc();

                veri.adapter = new MySqlDataAdapter("SELECT  musteriler.musteri_id AS MusteriİD,musteriler.ad, musteriler.soyad,musteriler.tc,musteriler.adres,musteriler.tel,musteriler.arac_id AS AracİD,araclar.marka,araclar.model,sigorta_sirketleri.sigorta_adi AS Sigorta,filolar.filo_adi AS Filo FROM musteriler INNER JOIN sigorta_sirketleri ON sigorta_sirketleri.sigorta_id = musteriler.sigorta_id INNER JOIN filolar ON filolar.filo_id = musteriler.filo_id INNER JOIN araclar ON araclar.arac_id=musteriler.arac_id", veri.mysqlbaglan);
                veri.adapter.Fill(veri.dataset);
                veri.mysqlbaglan.Close();
                return veri.dataset;
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show("" + hata);
                throw;
            }
        }

        public void musteriEkle(Musteri musteri)
        {
            try
            {
                veri.BaglantıAc();
                veri.komut = new MySqlCommand("INSERT INTO musteriler(ad,soyad,tc,adres,tel,arac_id,sigorta_id,filo_id)values(@ad,@soyad,@tc,@adres,@tel,@arac_id,@sigorta_id,@filo_id)", veri.mysqlbaglan);
                veri.komut.Parameters.AddWithValue("@ad", musteri.Ad);
                veri.komut.Parameters.AddWithValue("@soyad", musteri.SoyAd);
                veri.komut.Parameters.AddWithValue("@tc", musteri.Tc);
                veri.komut.Parameters.AddWithValue("@adres", musteri.Adres);
                veri.komut.Parameters.AddWithValue("@tel", musteri.Telefon);
                veri.komut.Parameters.AddWithValue("@arac_id", musteri.Aracİd);
                veri.komut.Parameters.AddWithValue("@sigorta_id", musteri.Sigortaİd);
                veri.komut.Parameters.AddWithValue("@filo_id", musteri.Filoİd);
                veri.komut.ExecuteNonQuery();
                veri.BaglantıKapat();
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
        public void aracEkle(Arac arac)
        {
            try
            {
                veri.BaglantıAc();
                veri.komut = new MySqlCommand("INSERT INTO araclar(marka,model,yil,sase_no,plaka,sigorta_id,filo_id)values(@marka,@model,@yil,@sase_no,@plaka,@sigorta_id,@filo_id)", veri.mysqlbaglan);
                veri.komut.Parameters.AddWithValue("@marka",arac.marka);
                veri.komut.Parameters.AddWithValue("@model", arac.model);
                veri.komut.Parameters.AddWithValue("@yil", arac.yil);
                veri.komut.Parameters.AddWithValue("@sase_no",arac.saseno);
                veri.komut.Parameters.AddWithValue("@plaka", arac.plaka);
                veri.komut.Parameters.AddWithValue("@sigorta_id", arac.sigortaid);
                veri.komut.Parameters.AddWithValue("@filo_id", arac.filoid);
                veri.komut.ExecuteNonQuery();
                veri.BaglantıKapat();
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
        public void İslemekle(Yapılanislem islem)
        {
            veri.mysqlbaglan.Open();
            veri.komut = new MySqlCommand("INSERT INTO gecmis(arac_id,parca,islem,bedel) values(@arac_id,@parca,@islem,@bedel)", veri.mysqlbaglan);
            veri.komut.Parameters.AddWithValue("@arac_id", islem.arac_id);
            veri.komut.Parameters.AddWithValue("@parca", islem.parca);
            veri.komut.Parameters.AddWithValue("@islem", islem.islem);
            veri.komut.Parameters.AddWithValue("@bedel", islem.bedel);
            veri.komut.ExecuteNonQuery();
        }

        public void Sil(string index,string tablo,string sutun)
        {
            try
            {
                System.Windows.Forms.DialogResult secim;
                secim = System.Windows.Forms.MessageBox.Show("Seçmiş Olduğunuz Kayıt Silinecektir Onaylıyor musunuz?", "Uyarı", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question);
                if (secim == System.Windows.Forms.DialogResult.Yes)
                {
                    veri.BaglantıAc();
                    veri.komut.Connection = veri.mysqlbaglan;
                    veri.komut.CommandText = "DELETE FROM "+tablo+" WHERE "+sutun+"=" + index + "";
                    veri.komut.ExecuteNonQuery();
                    veri.komut.Dispose();
                    veri.mysqlbaglan.Close();
                    
                    System.Windows.Forms.MessageBox.Show("Seçili Kayıt Başarıyla Silindi");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Silme Kayıt İptal Edilmiştir");
                }
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show("" + hata);
            }

        }
        
        public void musteriGuncelle(Musteri musteri)
        {
            try
            {
                veri.BaglantıAc();
                veri.komut = new MySqlCommand("UPDATE musteriler set musteri_adsoyad=@musteri_adsoyad,musteri_tel=@musteri_tel,musteri_adres=@musteri_adres Where musteri_id=@musteri_id", veri.mysqlbaglan);
                veri.komut.Parameters.AddWithValue("@musteri_adsoyad", musteri.Ad);
                veri.komut.Parameters.AddWithValue("@musteri_tel", musteri.SoyAd);
                veri.komut.Parameters.AddWithValue("@musteri_adres", musteri.Adres);
                veri.komut.Parameters.AddWithValue("@musteri_id", musteri.Telefon);
                veri.komut.ExecuteNonQuery();

                veri.BaglantıKapat();
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show("" + hata);
                throw;
            }
            finally
            {
                System.Windows.Forms.MessageBox.Show("Güncelleme İşlemi Başarılı");
            }

        }
    }
}
