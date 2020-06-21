using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;
using EntityLayer;
namespace BusinessLogicLayer
{
   public class BLLMusteri
    {
        public static List<EntityMusteri> BLLMusteriistesi()
        {
            return DALMusteri.MusteriListesi();
        }

        public static int BLLMusteriEkle(EntityMusteri musteri)
        {
            if (musteri.MusteriSoyad!= null && musteri.MusteriSoyad != " "&&musteri.MusteriAd!="")
                return DALMusteri.MusteriEkle(musteri);
            return -1;
        }

        public static bool MuseriSil(EntityMusteri musterisil)
        {
            if (musterisil.MusteriId!= 0)
            {
                return DALMusteri.MusteriSil(musterisil);
            }

            return false;
        }
        public static List<EntityMusteri> GuncellemeSayfasiMusteriListele(int id)
        {
            return DALMusteri.GuncellemeSayfasinaMusteriListele(id);
        }

        public static bool MusteriGuncelle(EntityMusteri musteri)
        {
            if (musteri.MusteriAd != " " && musteri.MusteriSoyad != " ")
                return DALMusteri.MusteriGuncelle(musteri);
            return false;
        }
    }
}
