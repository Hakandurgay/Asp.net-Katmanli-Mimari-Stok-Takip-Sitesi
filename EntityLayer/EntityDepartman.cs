using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
   public class EntityDepartman
   {
       private int depertmanId; // sqlde tiny int olsaydı burada byte olacaktı 
       private string departmanAd;

       public int DepertmanId
       {
           get => depertmanId;
           set => depertmanId = value;
       }

       public string DepartmanAd
       {
           get => departmanAd;
           set => departmanAd = value;
       }
   }
}
