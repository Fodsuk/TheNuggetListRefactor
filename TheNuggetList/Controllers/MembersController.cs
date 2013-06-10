using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheNuggetList.Commands.Nuggets.Executors;

namespace TheNuggetList.Website.Controllers
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
