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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityDepartman> DepList = BLLDepartman.BllDepartmanListele();
            Repeater1.DataSource = DepList;
            Repeater1.DataBind();  //evalin içineentity layerda oluşturduğun değişkenin adını yaz. 
            
        }
    }
}