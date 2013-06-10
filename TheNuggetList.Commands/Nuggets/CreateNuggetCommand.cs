using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Radiator.Core.Commanding;
using TheNuggetList.Domain.Members;

namespace TheNuggetList.Commands.Nuggets
{
    public class CreateNuggetCommand : Command 
    {
        public string Title { get; set; }
        public string Description { get; set; }
		public Member Member { get; set; }
    }
}
