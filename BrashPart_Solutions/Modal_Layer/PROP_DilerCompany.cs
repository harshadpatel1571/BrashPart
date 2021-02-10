using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modal_Layer
{
    public class PROP_DilerCompany
    {
        public int DC_id { get; set; }
        public string DC_CompanyName { get; set; }
        public string DC_OwnerName { get; set; }
        public int CM_CompanyId { get; set; }
        public int Sub_CmId { get; set; }
        public int CM_CountryID { get; set; }
        public int SM_StateID { get; set; }
        public int CM_CityId { get; set; }
        public string DC_PhoneNo { get; set; }
        public string DC_PhoneNo1 { get; set; }
        public string DC_Address { get; set; }
        public string DC_Email { get; set; }
        public string DC_GSTNO { get; set; }
        public int DC_IsActive { get; set; }
        public int UserId { get; set; }

    }
}
