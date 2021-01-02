using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace DB_Layer
{
    public class Connection
    {
        public static SqlConnection connect()
        {
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["GJ10"].ConnectionString);
            return con;
        }

        public static SqlConnection connection_open()
        {
            SqlConnection con = connect();
            con.Open();
            return con;
        }

        public static void connection_close()
        {
            SqlConnection con = connect();
            con.Open();
            con.Dispose();
            GC.Collect();
        }
    }
}
