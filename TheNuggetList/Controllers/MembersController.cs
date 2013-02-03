using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TheNuggetList.Controllers
{
    public class MembersController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

		public ActionResult Logout()
		{
			return View();
		}
    }
}
