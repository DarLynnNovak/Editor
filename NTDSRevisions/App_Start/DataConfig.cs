using AcsAptify;
using System.Configuration;

namespace App
{
    public class DataConfig
    {
        public static void ConfigureData()
        {
            bool trusted = ConfigurationManager.AppSettings["SQLTrusted"] == "1";
            var aptifyuserid = int.Parse(ConfigurationManager.AppSettings["AptifyUserId"]);
            var lCredentials = new AptifyCredentials
            {
                AllowGUI = false,
                ApplicationName = ConfigurationManager.AppSettings["ApplicationName"],
                AptifyUserId = aptifyuserid,
                CultureId = 1,
                EntitiesDatabase = "Aptify",
                SQLLogin = ConfigurationManager.AppSettings["SQLLogin"],
                Password = ConfigurationManager.AppSettings["SQLPassword"],
                Trusted = trusted,
                Server = ConfigurationManager.AppSettings["AptifyDBServer"],
                SysAdminUser = true,
                UsersDatabase = "Aptify"
            };

            AptifyEntity.AptifyCredentials = lCredentials;
        }
    }
}