using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
   public class EntityUrun
   {
       private int urunId;
       private string urunAd;
       private decimal urunFiyat;
       private int urunAdet;


        public int UrunId { get => urunId; set => urunId = value; }
        public string UrunAd { get => urunAd; set => urunAd = value; }
        public decimal UrunFiyat { get => urunFiyat; set => urunFiyat = value; }
        public int UrunAdet { get => urunAdet; set => urunAdet = value; }
    }

}
