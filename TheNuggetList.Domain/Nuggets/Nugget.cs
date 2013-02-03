using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheNuggetList.Domain.Nuggets
{
    public class Nugget    
    {
        public Nugget()
        {
            Created = DateTime.Now;
        }

        public int Id { get; set; }
		public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
    }
}
