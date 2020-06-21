using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Data_Access_Layer
{
   public class Baglanti
    {
        public static SqlConnection baglanti =new SqlConnection(@"Data Source=HAKAN\SQLEXPRESS;Initial Catalog=MYUdemy2personnel;Integrated Security=True");
    }
}
