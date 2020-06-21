using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
   public class EntityMusteri
    {
        private int musteriId;
        private string musteriAd;
        private string musteriSoyad;

        public int MusteriId { get => musteriId; set => musteriId = value; }
        public string MusteriAd { get => musteriAd; set => musteriAd = value; }
        public string MusteriSoyad { get => musteriSoyad; set => musteriSoyad = value; }
    }
}
