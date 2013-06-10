using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Radiator.Core.Commanding;
using Radiator.Core;

namespace TheNuggetList.Commands.Members.Validators
{
	public class AuthenticateMemberValidator : BaseValidator<AuthenticateMemberCommand>
    {
		public override ProcessResult ValidateCommand(AuthenticateMemberCommand command)
        {
            if (IsEmptyOrNullString(command.UsernameOrEmailAddress))
                return FailedResult("You must provide a username or email address.");

            if (IsEmptyOrNullString(command.Password))
                return FailedResult("You must provide a password.");

            return SuccessfulResult();           
        }
    }
}
