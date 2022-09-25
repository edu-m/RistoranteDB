using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ristorante
{
    public class Utility
    {
        public static string connString = "Data Source=PC-ILA\\SQLEXPRESS;Initial Catalog=Ristorante;Integrated Security=True";
        public static string loggedUser = "-1";
  
        
        /*public static string GetConnectionStrings()
       {
           String connStr = "";
           ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;

           if (settings != null)
           {
               foreach (ConnectionStringSettings cs in settings)
               {
                   if (cs.Name.Equals("RistConnectionString"))
                       connStr = cs.ConnectionString;
               }
           }
           return connStr;
       }*/

    }
}
