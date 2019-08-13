namespace My_App_03b.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Username = c.Int(nullable: false),
                        Password = c.Int(nullable: false),
                        FirstName = c.Int(nullable: false),
                        LastName = c.Int(nullable: false),
                        Email = c.Int(nullable: false),
                        Mobile = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
