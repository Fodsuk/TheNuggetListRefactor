using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject.Modules;
using Ninject.Extensions.Conventions;
using System.Data.Entity;
using TheNuggetList.Data;
using Ninject.Web.Common;

namespace TheNuggetList.NinjectModules
{
    public class DataModule : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind(x =>
                x.FromAssembliesMatching("TheNuggetList.Data.dll")
                .SelectAllClasses()
                .BindAllInterfaces()
            );

            Kernel.Bind<NuggetDbContext>().ToSelf().InRequestScope();
        }
    }
}