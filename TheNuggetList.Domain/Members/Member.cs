using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheNuggetList.Domain.Nuggets;

namespace TheNuggetList.Domain.Members
{
	public class Member
	{
		public int Id { get; set; }
		public string Username { get; set; }
		public string EmailAddress { get; set; }
		public string Password { get; set; }
		public DateTime Created { get; set; }
		public virtual ICollection<Nugget> Nuggets { get; set; }
	}
}
