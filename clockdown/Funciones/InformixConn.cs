using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using System.Configuration;
using clockdown.Properties;

namespace clockdown
{
    public class InformixConn
    {
        public static OdbcConnection GetConnection()
        {
            string informixConn = Settings.Default.InformixConnectionString;
            return new OdbcConnection (informixConn);
        }

    }
}
