using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using TheNuggetList.Domain.Nuggets;

namespace TheNuggetList.Data
{
    public class NuggetDbContext : DbContext
    {
        public DbSet<Nugget> Nuggets { get; set; }
    }
}
