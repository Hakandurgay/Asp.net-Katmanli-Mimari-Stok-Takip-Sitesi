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
    public partial class MusteriGuncellemeSayfasi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["MUSTERIID"]);
            TextBox3.Text = x.ToString();
            EntityMusteri ent=new EntityMusteri();
            if (Page.IsPostBack == false)
            {
                List<EntityMusteri> musterilistesi = BLLMusteri.GuncellemeSayfasiMusteriListele(x);
                TextBox1.Text = musterilistesi[0].MusteriAd.ToString();
                TextBox2.Text = musterilistesi[0].MusteriSoyad.ToString();
            }
       
        }

        protected void kaydet_Click(object sender, EventArgs e)
        {
            EntityMusteri guncelle=new EntityMusteri();
            guncelle.MusteriAd = TextBox1.Text;
            guncelle.MusteriSoyad = TextBox2.Text;
            guncelle.MusteriId = Convert.ToInt32(TextBox3.Text);
            BLLMusteri.MusteriGuncelle(guncelle);
            Response.Redirect("Musteriler.aspx");
        }
    }
}