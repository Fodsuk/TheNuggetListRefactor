using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject.Modules;
using Radiator.Core;
using Radiator.Core.Commanding;
using Microsoft.Practices.ServiceLocation;
using TheNuggetList.Commands.Nuggets;
using TheNuggetList.Commands.Nuggets.Validators;
using TheNuggetList.Commands.Nuggets.Executors;

namespace TheNuggetList.NinjectModules
{
    public class CommandingModule : NinjectModule
    {

        public override void Load()
        {
            //command service
            Configuration commandConfig = new Configuration(new NinjectDependencyResolver());
            Kernel.Bind<ICommandService>().ToMethod(_ => { return new CommandService(commandConfig); });

            //validators
            Kernel.Bind<CommandValidator<CreateNuggetCommand>>().To<CreateNuggetValidator>();

            //executors
            Kernel.Bind<CommandExecutor<CreateNuggetCommand>>().To<CreateNuggetExecutor>();
        }
    }

    
    public class NinjectDependencyResolver : IDependencyResolver
    {
        public CommandExecutor<TCommand> GetExecutor<TCommand>(TCommand command) where TCommand : Command
        {
            return ServiceLocator.Current.GetInstance<CommandExecutor<TCommand>>();
        }
        public CommandValidator<TCommand> GetValidator<TCommand>(TCommand command) where TCommand : Command
        {
            return ServiceLocator.Current.GetInstance<CommandValidator<TCommand>>();
        }
    }
}