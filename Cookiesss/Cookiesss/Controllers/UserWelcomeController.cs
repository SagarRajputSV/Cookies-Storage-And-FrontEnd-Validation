using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cookiesss.Controllers
{
    public class UserWelcomeController : Controller
    {
        // GET: UserWelcome
        public ActionResult Index()
        {
            return View();
        }
    }
}