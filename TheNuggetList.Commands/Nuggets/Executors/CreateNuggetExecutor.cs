using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Radiator.Core.Commanding;
using Radiator.Core;

namespace TheNuggetList.Commands.Nuggets.Executors
{
    public class CreateNuggetExecutor : CommandExecutor<CreateNuggetCommand>
    {
        public override ProcessResult ExecuteCommand(ICommandService commandService, CreateNuggetCommand command)
        {
            return new ProcessResult()
            {
                Successful = true
            };
        }
    }
}
