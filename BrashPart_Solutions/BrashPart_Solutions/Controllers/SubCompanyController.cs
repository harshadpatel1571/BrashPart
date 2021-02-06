using DB_Layer;
using Modal_Layer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BrashPart_Solutions.Controllers
{
    [Authorize]
    public class SubCompanyController : Controller
    {
        BAL_SubCompany BAL_Sub = new BAL_SubCompany();
        // GET: SubCompany
        public ActionResult SubCompanuList()
        {
            return View();
        }

        [HttpPost]
        public string ChekSubCompanyList(int id)
        {
            string JSONString = "";

            DataTable dt = BAL_Sub.logincheck(id);
            
            return JSONString = JsonConvert.SerializeObject(dt);
        }

        [HttpPost]
        public string SubCompanySession(int Sub_CmId)
        {
            string JSONString = "";
            Session["SubCompany"] = Sub_CmId;

            return JSONString = JsonConvert.SerializeObject(Sub_CmId);
        }   
    }
}