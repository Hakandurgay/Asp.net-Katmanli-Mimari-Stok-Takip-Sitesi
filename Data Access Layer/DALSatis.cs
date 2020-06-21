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
   public class DALSatis
    {
        public static List<EntitySatis> SatisListesi()
        {
            List<EntitySatis> degerler = new List<EntitySatis>();
            SqlCommand komut = new SqlCommand("SATISLAR", Baglanti.baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            if (komut.Connection.State != ConnectionState.Open)
                komut.Connection.Open();

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntitySatis ent = new EntitySatis();
                ent.SatisId = int.Parse(dr["SATISID"].ToString());
                ent.UrunAd = dr["URUNAD"].ToString();
                ent.PersonelAd = dr["PERSONEL"].ToString();    //PROSEDÜRÜ YAZARKEN PERSONEL OLARAK ETİKETLEDİK. O YÜZDEN BURADA TEK TEK AT SOYAD YAZMAK YERİNE O TAGİ YAZARSAN İKİSİNİ DE YAZDIRIR
              //  ent.PersonelSoyad = dr["PERSONELSOYAD"].ToString();
                ent.MusteriAd = dr["MUSTERIM"].ToString();
            //    ent.MusteriSoyad = dr["MUSTERISOYAD"].ToString();
         //        ent.Fiyat = decimal.Parse(dr["TUTAR"].ToString());
                degerler.Add(ent);

            }
            dr.Close();
            return degerler;

        }
    }
}
