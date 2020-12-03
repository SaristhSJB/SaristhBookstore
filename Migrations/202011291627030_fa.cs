namespace SaristhBookstore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SystemUsers", "userTypeId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SystemUsers", "userTypeId");
        }
    }
}
