using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data;
using  System.Data.SqlClient;
namespace Data_Access_Layer
{
   public class DALDepartman
    {
        public static List<EntityDepartman> DepartmanListesi()
        {
            List<EntityDepartman> degerler=new List<EntityDepartman>();

            SqlCommand komut=new SqlCommand("select * from TBLDEPARTMAN", Baglanti.baglanti);
            if(komut.Connection.State!=ConnectionState.Open)
                komut.Connection.Open();
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityDepartman ent = new EntityDepartman();
                ent.DepertmanId = byte.Parse(dr["DEPARTMANID"].ToString());
                ent.DepartmanAd = dr["DEPARTMANAD"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static int DepartmanEkle(EntityDepartman departman)
        {
            SqlCommand ekle=new SqlCommand("insert into TBLDEPARTMAN (DEPARTMANAD) values (@departmanad)",Baglanti.baglanti);
            if (ekle.Connection.State != ConnectionState.Open)
                ekle.Connection.Open();
            ekle.Parameters.AddWithValue("@departmanad", departman.DepartmanAd);
            return ekle.ExecuteNonQuery();
        }
    }
}
