namespace SaristhBookstore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class iia : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comments", "BookName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Comments", "BookName");
        }
    }
}
