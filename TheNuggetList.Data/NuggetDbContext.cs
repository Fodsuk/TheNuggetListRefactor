using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using TheNuggetList.Domain.Nuggets;
using TheNuggetList.Domain.Members;

namespace TheNuggetList.Data
{
    public class NuggetDbContext : DbContext
	{
		public DbSet<Member> Members { get; set; }
        public DbSet<Nugget> Nuggets { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Member>().HasMany<Nugget>(x => x.Nuggets).WithRequired(x => x.Member);
		}
    }
}
