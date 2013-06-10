using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Radiator.Core.Commanding;
using Radiator.Core;
using TheNuggetList.Data;
using TheNuggetList.Domain.Members;

namespace TheNuggetList.Commands.Members.Executors
{
    public class AuthenticateMemberExecutor : BaseExecutor<AuthenticateMemberCommand>
    {
		public AuthenticateMemberExecutor(NuggetDbContext context) : base(context) { }

		public override ProcessResult ExecuteCommand(ICommandService commandService, AuthenticateMemberCommand command)
        {
			bool memberExists = NuggetDbContext.Members.Any(x => 
				(x.EmailAddress == command.UsernameOrEmailAddress || x.Username == command.UsernameOrEmailAddress) 
				&& x.Password == command.Password);

			if (!memberExists)
				return FailedResult();

            return SuccessfulResult();
        }
    }
}
