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
    public class BAL_SubCompany
    { 
        public DataTable logincheck(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "GJ_SubCompanyMaster_Select";
            cmd.Parameters.AddWithValue("@Cm_CompanyId",id);
            

            DataTable dt = new DataTable();
            return dt = Command.ExecuteQuery(cmd);
        }
    }
}
