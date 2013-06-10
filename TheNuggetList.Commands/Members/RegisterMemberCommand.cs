using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Radiator.Core.Commanding;

namespace TheNuggetList.Commands.Members
{
	public class RegisterMemberCommand : Command
	{
		public string Username { get; set; }
		public string EmailAddress { get; set; }
		public string Password { get; set; }
	}
}
