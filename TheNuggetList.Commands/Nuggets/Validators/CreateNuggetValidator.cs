using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Radiator.Core.Commanding;
using Radiator.Core;

namespace TheNuggetList.Commands.Nuggets.Validators
{
    public class CreateNuggetValidator : CommandValidator<CreateNuggetCommand>
    {
        public override ProcessResult ValidateCommand(CreateNuggetCommand command)
        {
            return new ProcessResult()
            {
                Successful = true                
            };
        }
    }
}
