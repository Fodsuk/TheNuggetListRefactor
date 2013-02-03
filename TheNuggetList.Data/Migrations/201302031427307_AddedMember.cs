namespace TheNuggetList.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMember : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.Int(nullable: false),
                        EmailAddress = c.Int(nullable: false),
                        Password = c.Int(nullable: false),
                        Created = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Members");
        }
    }
}
