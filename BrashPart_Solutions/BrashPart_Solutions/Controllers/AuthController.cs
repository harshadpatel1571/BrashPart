using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Modal_Layer;
using DB_Layer;
using System.Data;
using System.Web.Security;

namespace BrashPart_Solutions.Controllers
{
    public class AuthController : Controller
    {

        //PROP_Authentication auth = new PROP_Authentication();

        // GET: Auth
        public ActionResult Login()
        {
            return View(new PROP_Authentication());
        }

        [HttpPost]
        public ActionResult ChekLogin(PROP_Authentication auth)
        {
            //DataTable dt = auth.logincheck(auth);
            //if (dt.Rows.Count > 0)
            //{
            //    FormsAuthentication.SetAuthCookie(dt.Rows[0]["UserName"].ToString(), false);
            //    return RedirectToAction("Dashboard", "DashBoard");
            //}
            //else
            //{
            //    return RedirectToAction("Login");
            //}
            return RedirectToAction("Login");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}