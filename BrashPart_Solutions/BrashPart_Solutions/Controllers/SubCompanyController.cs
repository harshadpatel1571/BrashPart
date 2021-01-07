using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BrashPart_Solutions.Controllers
{
    [Authorize]
    public class SubCompanyController : Controller
    {
        // GET: SubCompany
        public ActionResult SubCompanuList()
        {
            return View();
        }
    }
}