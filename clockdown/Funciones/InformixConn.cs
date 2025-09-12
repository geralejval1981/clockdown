using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using System.Configuration;

namespace clockdown
{
    public class InformixConn
    {
        public static OdbcConnection GetConnection()
        {
            return new OdbcConnection ("Dsn=Informix server");
        }

    }
}
