namespace TheNuggetList.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
	using TheNuggetList.Domain.Members;

    internal sealed class Configuration : DbMigrationsConfiguration<TheNuggetList.Data.NuggetDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TheNuggetList.Data.NuggetDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

			context.Members.AddOrUpdate(
				x => x.EmailAddress,
				new Member() { EmailAddress = "chrisnewark@gmail.com", Username = "Chris", Password = "password", Created = DateTime.Now }
			);
        }
    }
}
