using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Radiator.Core.Commanding;

namespace TheNuggetList.Commands.Nuggets
{
    public class CreateNuggetCommand : Command 
    {
        public string Title { get; set; }
    }
}
