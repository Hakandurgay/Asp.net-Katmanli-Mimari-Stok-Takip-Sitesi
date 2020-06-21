using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using Data_Access_Layer;
using BusinessLogicLayer;
namespace oopstok
{
    public partial class UrunEklemeSayfasi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void kaydet_Click(object sender, EventArgs e)
        {
            EntityUrun ekle = new EntityUrun();
            ekle.UrunAd = TextBox1.Text;
            ekle.UrunAdet = Convert.ToInt32(TextBox2.Text);
            ekle.UrunFiyat = Convert.ToInt32(TextBox3.Text);
            BLLUrun.BLLUrunEkle(ekle);
        }
    }
}