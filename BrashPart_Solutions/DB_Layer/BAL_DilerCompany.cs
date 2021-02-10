using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modal_Layer;
using System.Data;
using System.Data.SqlClient;
using DB_Layer;

namespace DB_Layer
{
    public class BAL_DilerCompany
    {
        public int Save(PROP_DilerCompany dc)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "GJ_DilerCompanyMaster_Insertupdate";
                cmd.Parameters.AddWithValue("@DC_Id",dc.DC_id);
                cmd.Parameters.AddWithValue("@DC_CompanyName",dc.DC_CompanyName);
                cmd.Parameters.AddWithValue("@DC_OwnerName",dc.DC_OwnerName);
                cmd.Parameters.AddWithValue("@CM_CompanyId",dc.CM_CompanyId);
                cmd.Parameters.AddWithValue("@Sub_CmId",dc.Sub_CmId);
                cmd.Parameters.AddWithValue("@CM_CountryID",dc.CM_CountryID);
                cmd.Parameters.AddWithValue("@SM_StateID",dc.SM_StateID);
                cmd.Parameters.AddWithValue("@CM_CityId",dc.CM_CityId);
                cmd.Parameters.AddWithValue("@DC_PhoneNo",dc.DC_PhoneNo);
                cmd.Parameters.AddWithValue("@DC_PhoneNo1",dc.DC_PhoneNo1);
                cmd.Parameters.AddWithValue("@DC_Address",dc.DC_Address);
                cmd.Parameters.AddWithValue("@DC_Email",dc.DC_Email);
                cmd.Parameters.AddWithValue("@DC_GSTNO",dc.DC_GSTNO);
                cmd.Parameters.AddWithValue("@DC_IsActive", dc.DC_IsActive);
                cmd.Parameters.AddWithValue("@UserId", dc.UserId);

                return Command.NonExecuteQuery(cmd);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public DataTable Get_all_data(int CompanyId)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "GJ_DilerCompanyMaster_Select";
                cmd.Parameters.AddWithValue("@Cm_CompanyId",CompanyId);
                DataTable dt = new DataTable();
                return dt = Command.ExecuteQuery(cmd);
            }
            catch (Exception ex)
            {
                DataTable dt = null;
                return dt;
            }
        }

        public DataTable Get_data_by_id(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Proc_Advance_mst_SelectByID";
                cmd.Parameters.AddWithValue("@id", id);
                DataTable dt = new DataTable();
                return dt = Command.ExecuteQuery(cmd);
            }
            catch (Exception ex)
            {
                DataTable dt = null;
                return dt;
            }
        }

        public int delete(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Proc_Advance_mst_Delete";
                cmd.Parameters.AddWithValue("@id", id);
                return Command.NonExecuteQuery(cmd);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
