using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;
using EntityLayer;

namespace BusinessLogicLayer
{
    public class BLLDepartman
    {
        public static List<EntityDepartman> BllDepartmanListele()
        {
            return DALDepartman.DepartmanListesi();
        }

        public static int BLLDepartmanEkle(EntityDepartman departman)
        {
            if (departman.DepartmanAd != null && departman.DepartmanAd!=" ")
                return DALDepartman.DepartmanEkle(departman);
            return -1;
        }
    }
}
