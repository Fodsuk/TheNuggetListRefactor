namespace TheNuggetList.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNuggetsAndMembers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        EmailAddress = c.String(),
                        Password = c.String(),
                        Created = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Nuggets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Created = c.DateTime(nullable: false),
                        Member_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Members", t => t.Member_Id, cascadeDelete: true)
                .Index(t => t.Member_Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Nuggets", new[] { "Member_Id" });
            DropForeignKey("dbo.Nuggets", "Member_Id", "dbo.Members");
            DropTable("dbo.Nuggets");
            DropTable("dbo.Members");
        }
    }
}
