using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Modal_Layer;
using DB_Layer;
using System.Data;
using System.Web.Security;
using DB_Layer;
using Newtonsoft.Json;

namespace BrashPart_Solutions.Controllers
{
    public class AuthController : Controller
    {

        BAL_Authenticatation BAL_auth = new BAL_Authenticatation();

        // GET: Auth
        public ActionResult Login()
        {
            return View(new PROP_Authentication());
        }

        [HttpPost]
        public string ChekLogin(PROP_Authentication auth)
        {
            string JSONString = "";

            DataTable dt = BAL_auth.logincheck(auth);
            if (dt.Rows.Count > 0)
            {
                FormsAuthentication.SetAuthCookie(dt.Rows[0]["FUllUserName"].ToString(), false);
            }
            return JSONString = JsonConvert.SerializeObject(dt);
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}