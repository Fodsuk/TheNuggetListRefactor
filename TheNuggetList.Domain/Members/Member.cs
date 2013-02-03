using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheNuggetList.Domain.Members
{
	public class Member
	{
		public int Id { get; set; }
		public int Username { get; set; }
		public int EmailAddress { get; set; }
		public int Password { get; set; }
		public DateTime Created { get; set; }
	}
}
