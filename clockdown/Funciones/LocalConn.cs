using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Configuration;
using clockdown.Properties;

namespace clockdown
{
    public class LocalConn
    {
        public static OleDbConnection GetConnection() {
            string accessConnection = Settings.Default.att2000ConnectionString;
            //string conn = ConfigurationManager.ConnectionStrings["Att2000DataSet"].ConnectionString;
            return new OleDbConnection(accessConnection);
        }
        
    }
}
