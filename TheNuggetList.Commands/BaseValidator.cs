using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Radiator.Core.Commanding;
using Radiator.Core;

namespace TheNuggetList.Commands
{
    public class BaseValidator<T> : CommandValidator<T> where T : Command
    {
        public override ProcessResult ValidateCommand(T command)
        {
            throw new NotImplementedException();
        }

        protected bool IsEmptyOrNullString(string str)
        {
            return String.IsNullOrWhiteSpace(str);
        }

        protected ProcessResult SuccessfulResult()
        {
            return SuccessfulResult(String.Empty);
        }

        protected ProcessResult SuccessfulResult(string message)
        {
            return new ProcessResult()
            {
                Successful = true,
                Message = message
            };
        }

        protected ProcessResult FailedResult()
        {
            return FailedResult(String.Empty);
        }

        protected ProcessResult FailedResult(string message)
        {
            return new ProcessResult()
            {
                Successful = false,
                Message = message
            };
        }
    }

}
