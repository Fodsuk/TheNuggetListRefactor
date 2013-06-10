using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Radiator.Core.Commanding;
using Radiator.Core;

namespace TheNuggetList.Commands.Members.Validators
{
	public class RegisterMemberValidator : BaseValidator<RegisterMemberCommand>
    {
		public override ProcessResult ValidateCommand(RegisterMemberCommand command)
        {
            if (IsEmptyOrNullString(command.Username))
                return FailedResult("You must provide a username.");

            if (IsEmptyOrNullString(command.EmailAddress))
                return FailedResult("You must provide a email address.");

			if (IsEmptyOrNullString(command.Password))
				return FailedResult("You must provide a password.");

            return SuccessfulResult();           
        }
    }
}
