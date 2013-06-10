using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Radiator.Core.Commanding;
using Radiator.Core;

namespace TheNuggetList.Commands.Nuggets.Validators
{
    public class CreateNuggetValidator : BaseValidator<CreateNuggetCommand>
    {
        public override ProcessResult ValidateCommand(CreateNuggetCommand command)
        {
            if (IsEmptyOrNullString(command.Title))
                return FailedResult("You must provide a Title.");

            if (IsEmptyOrNullString(command.Description))
                return FailedResult("You must provide a Description.");

			if (command.Member == null)
				return FailedResult("A nugget must be assigned to a member.");

            return SuccessfulResult();           
        }
    }
}
