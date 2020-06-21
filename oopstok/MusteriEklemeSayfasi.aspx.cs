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
    public partial class MusteriEklemeSayfasi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void kaydet_Click(object sender, EventArgs e)
        {
            EntityMusteri ekle = new EntityMusteri();
            ekle.MusteriAd = TextBox1.Text;
            ekle.MusteriSoyad = TextBox2.Text;
            BLLMusteri.BLLMusteriEkle(ekle);
        }
    }
}