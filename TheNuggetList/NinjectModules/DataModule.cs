using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject.Modules;
using Ninject.Extensions.Conventions;


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
        }
    }
}