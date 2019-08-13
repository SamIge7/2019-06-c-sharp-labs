namespace My_App_03b.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Username", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "FirstName", c => c.String());
            AlterColumn("dbo.Users", "LastName", c => c.String());
            AlterColumn("dbo.Users", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Mobile", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Mobile", c => c.Int(nullable: false));
            AlterColumn("dbo.Users", "Email", c => c.Int(nullable: false));
            AlterColumn("dbo.Users", "LastName", c => c.Int(nullable: false));
            AlterColumn("dbo.Users", "FirstName", c => c.Int(nullable: false));
            AlterColumn("dbo.Users", "Password", c => c.Int(nullable: false));
            AlterColumn("dbo.Users", "Username", c => c.Int(nullable: false));
        }
    }
}
