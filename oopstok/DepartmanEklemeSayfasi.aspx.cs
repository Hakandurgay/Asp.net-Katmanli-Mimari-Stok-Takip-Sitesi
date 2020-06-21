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
    public partial class DepartmanEklemeSayfasi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void kaydet_Click(object sender, EventArgs e)
        {
            EntityDepartman ekle=new EntityDepartman();
            ekle.DepartmanAd = TextBox1.Text;
            BLLDepartman.BLLDepartmanEkle(ekle);
        }
    }
}