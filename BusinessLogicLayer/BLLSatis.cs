using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;
using EntityLayer;
namespace BusinessLogicLayer
{
   public class BLLSatis
    {
        public static List<EntitySatis> BLLSatisListesi()
        {
            return DALSatis.SatisListesi();
        }
    }
}
