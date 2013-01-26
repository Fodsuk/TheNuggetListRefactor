namespace TheNuggetList.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTitleToNugget : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Nuggets", "Title", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Nuggets", "Title");
        }
    }
}
