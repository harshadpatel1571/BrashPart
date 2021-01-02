using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Layer
{
    public class Command
    {
        public static DataTable ExecuteQuery(SqlCommand cmd)
        {
            try
            {
                SqlConnection cn = Connection.connection_open();
                DataTable dt = new DataTable();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(dt);
                return dt;
            }
            finally
            {
                Connection.connection_close();
            }
        }

        // add by : Harshad
        public static DataSet DataExecuteQuery(SqlCommand cmd)
        {
            try
            {
                SqlConnection cn = Connection.connection_open();
                DataSet ds = new DataSet();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(ds);
                return ds;
            }
            finally
            {
                Connection.connection_close();
            }
        }

        public static int NonExecuteQuery(SqlCommand cmd)
        {
            try
            {
                SqlConnection cn = Connection.connection_open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
            }
            catch { }
            finally
            {
                Connection.connection_close();
            }
            return cmd.ExecuteNonQuery();
        }
    }
}
