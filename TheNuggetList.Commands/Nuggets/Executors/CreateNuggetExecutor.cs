using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Radiator.Core.Commanding;
using Radiator.Core;
using TheNuggetList.Data;
using TheNuggetList.Domain.Nuggets;

namespace TheNuggetList.Commands.Nuggets.Executors
{
    public class CreateNuggetExecutor : BaseExecutor<CreateNuggetCommand>
    {
        public CreateNuggetExecutor(NuggetDbContext context) : base(context) {  }

        public override ProcessResult ExecuteCommand(ICommandService commandService, CreateNuggetCommand command)
        {
            NuggetDbContext.Nuggets.Add(new Nugget()
            {
                Title = command.Title,
                Description = command.Description,
                Created = DateTime.Now
            });

            NuggetDbContext.SaveChanges();

            return SuccessfulResult();
        }
    }
}
