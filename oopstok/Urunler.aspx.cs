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
    public partial class Urunler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityUrun> UrunListesi = BLLUrun.BLLUrunListesi();
            Repeater1.DataSource = UrunListesi;
            Repeater1.DataBind();
        }
    }
}