using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EntityLayer;
using System.Data;
namespace Data_Access_Layer
{
  public  class DALMusteri
    {
        public static List<EntityMusteri> MusteriListesi()
        {
            List<EntityMusteri> degerler =new List<EntityMusteri>();
            SqlCommand komut=new SqlCommand("Select * from TBLMUSTERI",Baglanti.baglanti);
            if(komut.Connection.State!=ConnectionState.Open)
                komut.Connection.Open();

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityMusteri ent = new EntityMusteri();
                ent.MusteriId = int.Parse(dr["MUSTERIID"].ToString());
                ent.MusteriAd = dr["MUSTERIAD"].ToString();
                ent.MusteriSoyad = dr["MUSTERISOYAD"].ToString();
                degerler.Add(ent);

            }
            dr.Close();
            return degerler;

        }
        public static int MusteriEkle(EntityMusteri musteri)
        {
            SqlCommand ekle = new SqlCommand("insert into TBLMUSTERI (MUSTERIAD,MUSTERISOYAD) values (@MUSTERIAD,@MUSTERISOYAD)", Baglanti.baglanti);
            if (ekle.Connection.State != ConnectionState.Open)
                ekle.Connection.Open();
            ekle.Parameters.AddWithValue("@MUSTERIAD", musteri.MusteriAd);
            ekle.Parameters.AddWithValue("@MUSTERISOYAD", musteri.MusteriSoyad);

            return ekle.ExecuteNonQuery();
        }

        public static bool MusteriSil(EntityMusteri musterisil)
        {
            SqlCommand sil=new SqlCommand("Delete from TBLMUSTERI where MUSTERIID=@p1",Baglanti.baglanti);
            if (sil.Connection.State != ConnectionState.Open)
                sil.Connection.Open();
            sil.Parameters.AddWithValue("@p1", musterisil.MusteriId);
            return sil.ExecuteNonQuery() > 0;
        }
        public static List<EntityMusteri> GuncellemeSayfasinaMusteriListele(int id)
        {
            List<EntityMusteri> degerler = new List<EntityMusteri>();
            SqlCommand komut = new SqlCommand("Select * from TBLMUSTERI where MUSTERIID=@p1", Baglanti.baglanti);
            komut.Parameters.AddWithValue("@p1", id);
            if (komut.Connection.State != ConnectionState.Open)
                komut.Connection.Open();

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityMusteri ent = new EntityMusteri();
           
                ent.MusteriAd = dr["MUSTERIAD"].ToString();
                ent.MusteriSoyad = dr["MUSTERISOYAD"].ToString();
                degerler.Add(ent);

            }
            dr.Close();
            return degerler;
        }

        public static bool MusteriGuncelle(EntityMusteri musteri)
        {
            SqlCommand guncelle=new SqlCommand("update TBLMUSTERI set MUSTERIAD=@p1, MUSTERISOYAD=@p2 where MUSTERIID=@p3",Baglanti.baglanti);
            if (guncelle.Connection.State != ConnectionState.Open)
                guncelle.Connection.Open();

            guncelle.Parameters.AddWithValue("@p1", musteri.MusteriAd);
            guncelle.Parameters.AddWithValue("@p2", musteri.MusteriSoyad);
            guncelle.Parameters.AddWithValue("@p3", musteri.MusteriId);
            return guncelle.ExecuteNonQuery() > 0;

        }
    }
}
