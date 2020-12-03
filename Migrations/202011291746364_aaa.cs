namespace SaristhBookstore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aaa : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SystemUsers", "UserName", c => c.String(nullable: false));
            AlterColumn("dbo.SystemUsers", "password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SystemUsers", "password", c => c.String());
            AlterColumn("dbo.SystemUsers", "UserName", c => c.String());
        }
    }
}
