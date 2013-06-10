using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheNuggetList.Domain.Members;

namespace TheNuggetList.Domain.Nuggets
{
    public class Nugget    
    { 
        public int Id { get; set; }
		public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
		public virtual Member Member { get; set; }
    }
}
