[assembly: WebActivator.PreApplicationStartMethod(typeof(TheNuggetList.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivator.ApplicationShutdownMethodAttribute(typeof(TheNuggetList.App_Start.NinjectWebCommon), "Stop")]

namespace TheNuggetList.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
	using Ninject.Extensions.Conventions;
    using Radiator.Core;
    using Radiator.Core.Commanding;
    using Microsoft.Practices.ServiceLocation;
    using System.Collections.Generic;
    using TheNuggetList.Commands.Nuggets;
    using TheNuggetList.Commands.Nuggets.Validators;
    using TheNuggetList.Commands.Nuggets.Executors;
    using TheNuggetList.NinjectModules;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
            kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
            
            RegisterServices(kernel);
            return kernel;
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {

			kernel.Bind(x =>
				x.FromAssembliesMatching("TheNuggetList.Data.dll")
				.SelectAllClasses()
				.BindAllInterfaces()
			);
            
            kernel.Load(
                    new CommandingModule(), 
                    new DataModule());          

            //Common service locator
            ServiceLocator.SetLocatorProvider(() => new NinjectServiceLocator(kernel));
            
        }        
    }

    public class NinjectServiceLocator : ServiceLocatorImplBase
    {
        public IKernel Kernel { get; private set; }

        public NinjectServiceLocator(IKernel kernel)
        {
            Kernel = kernel;
        }

        protected override object DoGetInstance(Type serviceType, string key)
        {
            return Kernel.Get(serviceType, key);
        }

        protected override IEnumerable<object> DoGetAllInstances(Type serviceType)
        {
            return Kernel.GetAll(serviceType);
        }
    }

}
