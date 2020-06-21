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
    public partial class Personeller : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityPersonel> PersonelListesi = BLLPersonel.BLLPersonelListesi();
            Repeater1.DataSource = PersonelListesi;
            Repeater1.DataBind();
        }
    }
}