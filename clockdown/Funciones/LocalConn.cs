using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Configuration;

namespace clockdown
{
    public class LocalConn
    {
       
        public static OleDbConnection GetConnection() {
            //string conn = ConfigurationManager.ConnectionStrings["Att2000DataSet"].ConnectionString;
            return new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = R:\\att2000.mdb");
        }
        
    }
}
