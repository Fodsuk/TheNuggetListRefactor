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
    public class RegisterMemberExecutor : BaseExecutor<RegisterMemberCommand>
    {
		public RegisterMemberExecutor(NuggetDbContext context) : base(context) { }

		public override ProcessResult ExecuteCommand(ICommandService commandService, RegisterMemberCommand command)
        {
            NuggetDbContext.Members.Add(new Member()
            {
                Username = command.Username,
                EmailAddress = command.EmailAddress,
				Password = command.Password,
                Created = DateTime.Now
            });

            NuggetDbContext.SaveChanges();

            return SuccessfulResult();
        }
    }
}
