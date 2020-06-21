using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data;
using System.Data.SqlClient;
namespace Data_Access_Layer
{
   public class DALUrun
    {
        public static List<EntityUrun> UrunListesi()
        {
            List<EntityUrun> degerler = new List<EntityUrun>();
            SqlCommand komut = new SqlCommand("Select * From TBLURUN", Baglanti.baglanti);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityUrun ent = new EntityUrun();
                ent.UrunId = int.Parse(dr["URUNID"].ToString());
                ent.UrunAd = dr["URUNAD"].ToString();
                ent.UrunAdet = int.Parse(dr["URUNADET"].ToString());
                ent.UrunFiyat = decimal.Parse(dr["URUNFIYAT"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static int UrunEkle(EntityUrun urun)
        {
            SqlCommand ekle = new SqlCommand("insert into TBLURUN (URUNAD,URUNFIYAT,URUNADET) values (@AD,@FIYAT,@ADET)", Baglanti.baglanti);
            if (ekle.Connection.State != ConnectionState.Open)
                ekle.Connection.Open();
            ekle.Parameters.AddWithValue("@AD", urun.UrunAd);
            ekle.Parameters.AddWithValue("@FIYAT", urun.UrunFiyat);
            ekle.Parameters.AddWithValue("@ADET", urun.UrunAdet);

            return ekle.ExecuteNonQuery();
        }
    }
}
