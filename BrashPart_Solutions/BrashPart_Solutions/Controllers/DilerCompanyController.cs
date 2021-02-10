using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Modal_Layer;
using DB_Layer;
using Newtonsoft.Json;

namespace BrashPart_Solutions.Controllers
{
    public class DilerCompanyController : Controller
    {

        BAL_DilerCompany dcObj = new BAL_DilerCompany();
        int CompanyId = 0;
        // GET: DilerCompany
        public ActionResult ListDilerCompany()
        {
            return View();
        }

        public ActionResult DilerCompany()
        {
            return View();
        }

        [HttpPost]
        public string Save(PROP_DilerCompany dc)
        {
            dc.UserId = 1;
            dcObj.Save(dc);
            return "0";
        }

        [HttpPost]
        public string Get_data()
        {
            string JSONString = "";
            DataTable dt = dcObj.Get_all_data(CompanyId);
            return JSONString = JsonConvert.SerializeObject(dt);
        }

        [HttpPost]
        public string Get_data_by_id(int id)
        {
            string JSONString = "";
            DataTable dt = dcObj.Get_data_by_id(id);
            return JSONString = JsonConvert.SerializeObject(dt);
        }

        [HttpPost]
        public string Delete(int id)
        {
            dcObj.delete(id);
            return "0";
        }
    }
}