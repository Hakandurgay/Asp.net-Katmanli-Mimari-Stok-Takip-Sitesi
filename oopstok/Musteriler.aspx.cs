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
    public partial class Musteriler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityMusteri> musteriListesi = BLLMusteri.BLLMusteriistesi();
            Repeater1.DataSource = musteriListesi;
            Repeater1.DataBind();
        }
    }
}