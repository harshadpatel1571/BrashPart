using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BrashPart_Solutions.Controllers
{
    public class purchaseController : Controller
    {
        // GET: purchase
        public ActionResult ListPurchase()
        {
            return View();
        }

        public ActionResult Purchase()
        {
            return View();
        }

    }
}