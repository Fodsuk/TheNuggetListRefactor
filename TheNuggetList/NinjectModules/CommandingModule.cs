using Microsoft.Practices.ServiceLocation;
using Ninject.Modules;
using Ninject.Extensions.Conventions;
using Radiator.Core;
using Radiator.Core.Commanding;
using TheNuggetList.Commands.Nuggets;
using TheNuggetList.Commands.Nuggets.Executors;
using TheNuggetList.Commands.Nuggets.Validators;
using TheNuggetList.Commands;

namespace TheNuggetList.Website.NinjectModules
{
    public class CommandingModule : NinjectModule
    {

        public override void Load()
        {
            //command service
            Configuration commandConfig = new Configuration(new NinjectDependencyResolver());
            Kernel.Bind<ICommandService>().ToMethod(_ => { return new CommandService(commandConfig); });

			Kernel.Bind(x =>
				x.FromAssembliesMatching("TheNuggetList.Commands.dll")
				.SelectAllClasses()
				.InheritedFrom(typeof(BaseExecutor<>))
				.BindBase()
			);

			Kernel.Bind(x =>
				x.FromAssembliesMatching("TheNuggetList.Commands.dll")
				.SelectAllClasses()
				.InheritedFrom(typeof(BaseValidator<>))
				.BindBase()
			);
        }
    }
    
    public class NinjectDependencyResolver : IDependencyResolver
    {
        public CommandExecutor<TCommand> GetExecutor<TCommand>(TCommand command) where TCommand : Command
        {
            return ServiceLocator.Current.GetInstance<BaseExecutor<TCommand>>();
        }
        public CommandValidator<TCommand> GetValidator<TCommand>(TCommand command) where TCommand : Command
        {
            return ServiceLocator.Current.GetInstance<BaseValidator<TCommand>>();
        }
    }
}