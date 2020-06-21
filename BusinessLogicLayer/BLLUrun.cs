using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;
using EntityLayer;
namespace BusinessLogicLayer
{
   public class BLLUrun
    {
        public static List<EntityUrun> BLLUrunListesi()
        {
            return DALUrun.UrunListesi();
        }
        public static int BLLUrunEkle(EntityUrun urun)
        {
            if (urun.UrunAd != null  )
                return DALUrun.UrunEkle(urun);
            return -1;
        }
    }
}
