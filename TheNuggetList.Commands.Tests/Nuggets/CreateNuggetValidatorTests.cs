using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TheNuggetList.Commands.Nuggets.Validators;
using TheNuggetList.Commands.Nuggets;

namespace TheNuggetList.Commands.Tests.Nuggets
{
    [TestFixture]
    public class CreateNuggetValidatorTests
    {
        [Test]
        public void CreateNuggetValidator_EmptyTitle_ReturnsInvalidResult()
        {
            //Arrange
            var command = new CreateNuggetCommand();
            command.Description = "My Description";

            //Act
            var validator = new CreateNuggetValidator();
            var result = validator.ValidateCommand(command);

            //Assert
            Assert.AreEqual(false, result.Successful);
        }

        [Test]
        public void CreateNuggetValidator_EmptyDescription_ReturnsInvalidResult()
        {
            var command = new CreateNuggetCommand();
            command.Title = "My Title";

            var validator = new CreateNuggetValidator();
            var result = validator.ValidateCommand(command);

            Assert.AreEqual(false, result.Successful);
        }
    }
}
