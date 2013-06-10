using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Radiator.Core.Commanding;

namespace TheNuggetList.Commands.Members
{
	public class AuthenticateMemberCommand : Command
	{
		public string UsernameOrEmailAddress { get; set; }
		public string Password { get; set; }
	}
}
