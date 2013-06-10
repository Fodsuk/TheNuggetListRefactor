using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TheNuggetList.Commands.Members;
using TheNuggetList.Commands.Members.Validators;

namespace TheNuggetList.Commands.Tests.Members
{
	[TestFixture]
	public class RegisterMemberValidatorTests
	{
		[Test]
		public void RegisterMemberValidator_EmptyUsername_ReturnsInvalidResult()
		{
			var command = new RegisterMemberCommand();
			command.EmailAddress = "Test";
			command.Password = "Test";

			var validator = new RegisterMemberValidator();
			var result = validator.ValidateCommand(command);

			Assert.AreEqual(false, result.Successful);
		}

		[Test]
		public void RegisterMemberValidator_EmptyEmailAddress_ReturnsInvalidResult()
		{
			var command = new RegisterMemberCommand();
			command.Username = "Test";
			command.Password = "Test";

			var validator = new RegisterMemberValidator();
			var result = validator.ValidateCommand(command);

			Assert.AreEqual(false, result.Successful);
		}

		[Test]
		public void RegisterMemberValidator_EmptyPassword_ReturnsInvalidResult()
		{
			var command = new RegisterMemberCommand();
			command.Username = "Test";
			command.EmailAddress = "Test";

			var validator = new RegisterMemberValidator();
			var result = validator.ValidateCommand(command);

			Assert.AreEqual(false, result.Successful);
		}
	}
}
