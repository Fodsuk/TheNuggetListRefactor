using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject.Modules;
using Ninject.Extensions.Conventions;
using System.Data.Entity;
using TheNuggetList.Data;
using Ninject.Web.Common;
using System.Web.Security;

namespace TheNuggetList.Website.NinjectModules
{
    public class WebsiteModule : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind(x =>
                x.FromThisAssembly()
                .SelectAllClasses()
                .BindAllInterfaces()
            );

			Kernel.Bind<HttpContext>().ToConstant(HttpContext.Current);

			//KernelInstance.Inject(Roles.Provider);
        }
    }
}