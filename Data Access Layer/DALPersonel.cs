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
 public  class DALPersonel
    {
        public static List<EntityPersonel> PersonelListesi()
        {
            List<EntityPersonel> degerler=new List<EntityPersonel>();
            SqlCommand komut=new SqlCommand("DEPARTMANLISTELE", Baglanti.baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State!=ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityPersonel ent=new EntityPersonel();
                ent.PersonelId = int.Parse(dr["PERSONELID"].ToString());
                ent.PersonelAd = dr["PERSONELAD"].ToString();
                ent.PersonelSoyad=dr["PERSONELSOYAD"].ToString();
                ent.PersonelMaas = decimal.Parse(dr["PERSONELMAAS"].ToString());
                ent.PersonelDepartmanAd = dr["DEPARTMANAD"].ToString();
                ent.PersonelFotograf = dr["PERSONELFOTOGRAF"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
    }
}
