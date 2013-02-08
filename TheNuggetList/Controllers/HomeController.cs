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
using TheNuggetList.ViewModels;

namespace TheNuggetList.Controllers
{
    public class HomeController : Controller
    {    
        public HomeController(ICommandService commandService)
        {            
        }

        public ActionResult Index()
        {
            //TODO: Newark, you need to fetch these
            var nuggets = new List<HomeNuggetListItemViewModel>()
                {
                    new HomeNuggetListItemViewModel()
                        {
                            Title = "I Can Typing",
                            Description = "I Can Typing",
                            Created = new DateTime(2013, 02, 08, 22, 59, 00)
                        }
                };

            return View(new HomeViewModel() { Nuggets = nuggets });
        }
    }
}