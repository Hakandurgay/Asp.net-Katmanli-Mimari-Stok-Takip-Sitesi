using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using BusinessLogicLayer;
using Data_Access_Layer;
namespace oopstok
{
    public partial class MusteriSilmeSayfasi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["MUSTERIID"]);
            EntityMusteri ent=new EntityMusteri();
            ent.MusteriId = x;
            BLLMusteri.MuseriSil(ent);
            Response.Redirect("Musteriler.aspx");
        }
    }
}