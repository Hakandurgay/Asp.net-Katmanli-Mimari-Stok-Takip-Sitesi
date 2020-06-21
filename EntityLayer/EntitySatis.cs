using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
  public  class EntitySatis
  {
      private int satisId;
      private int urun;
      private int personel;
      private decimal fiyat;
      private int musteri;
      private string musteriAd;
      private string musteriSoyad;
      private string urunAd;
      private string personelAd;
      private string personelSoyad;

        public int SatisId { get => satisId; set => satisId = value; }
        public int Urun { get => urun; set => urun = value; }
        public int Personel { get => personel; set => personel = value; }
        public decimal Fiyat { get => fiyat; set => fiyat = value; }
        public int Musteri { get => musteri; set => musteri = value; }

        public string MusteriAd
        {
            get => musteriAd;
            set => musteriAd = value;
        }

        public string MusteriSoyad
        {
            get => musteriSoyad;
            set => musteriSoyad = value;
        }

        public string UrunAd
        {
            get => urunAd;
            set => urunAd = value;
        }

        public string PersonelAd
        {
            get => personelAd;
            set => personelAd = value;
        }

        public string PersonelSoyad
        {
            get => personelSoyad;
            set => personelSoyad = value;
        }
  }
}
