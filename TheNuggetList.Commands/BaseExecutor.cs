using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Radiator.Core.Commanding;
using Radiator.Core;
using TheNuggetList.Data;

namespace TheNuggetList.Commands
{
    public abstract class BaseExecutor<T> : CommandExecutor<T> where T : Command
    {
        public BaseExecutor()
        {
        }

        public BaseExecutor(NuggetDbContext nuggetDbContext)
        {
            NuggetDbContext = nuggetDbContext;            
        }
        
        protected NuggetDbContext NuggetDbContext { get; private set; }
        
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
