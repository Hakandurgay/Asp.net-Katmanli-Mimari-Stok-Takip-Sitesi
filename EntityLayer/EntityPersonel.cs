using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
   public class EntityPersonel
    {
        private int personelId;
        private string personelAd;
        private string personelSoyad;
        private byte personelDepartman;
        private decimal personelMaas;
        private string personelFotograf;
        private string personelDepartmanAd;
        public int PersonelId
        {
            get => personelId;
            set => personelId = value;
        }
        public string PersonelAd { get => personelAd; set => personelAd = value; }
        public string PersonelSoyad { get => personelSoyad; set => personelSoyad = value; }
        public byte PersonelDepartman { get => personelDepartman; set => personelDepartman = value; }

        public decimal PersonelMaas
        {
            get => personelMaas;
            set => personelMaas = value;
        }
        public string PersonelFotograf { get => personelFotograf; set => personelFotograf = value; }

        public string PersonelDepartmanAd
        {
            get => personelDepartmanAd;
            set => personelDepartmanAd = value;
        }
    }
}
