using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modal_Layer;

namespace DB_Layer
{
    public class BAL_Authenticatation
    {
        public DataTable logincheck(PROP_Authentication pa)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "GJ_AdminLogin";
            cmd.Parameters.AddWithValue("@UserName", pa.UserName);
            cmd.Parameters.AddWithValue("@Password", pa.Password);

            DataTable dt = new DataTable();
            return dt = Command.ExecuteQuery(cmd);
        }
    }
}
