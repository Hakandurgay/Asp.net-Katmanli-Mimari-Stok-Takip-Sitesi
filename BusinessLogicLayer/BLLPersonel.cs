using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using Data_Access_Layer;
namespace BusinessLogicLayer
{
    public class BLLPersonel
    {
        public static List<EntityPersonel> BLLPersonelListesi()
        {
            return DALPersonel.PersonelListesi();
        }
    }
}
