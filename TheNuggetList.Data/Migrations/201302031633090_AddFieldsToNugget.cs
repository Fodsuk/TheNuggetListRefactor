namespace TheNuggetList.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFieldsToNugget : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Nuggets", "Description", c => c.String());
            AddColumn("dbo.Nuggets", "Created", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Nuggets", "Created");
            DropColumn("dbo.Nuggets", "Description");
        }
    }
}
