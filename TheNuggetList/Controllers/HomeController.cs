using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheNuggetList.Domain.Nuggets;
using TheNuggetList.Data;
using Radiator.Core;
using TheNuggetList.Commands.Nuggets;

namespace TheNuggetList.Controllers
{
    public class HomeController : Controller
    {    
        public HomeController(ICommandService commandService)
        {            
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}