namespace SaristhBookstore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Carts", "BookId", c => c.Int(nullable: false));
            AddColumn("dbo.OrderDetails", "BookId", c => c.Int(nullable: false));
            AddColumn("dbo.OrderDetails", "Quantity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.OrderDetails", "Quantity");
            DropColumn("dbo.OrderDetails", "BookId");
            DropColumn("dbo.Carts", "BookId");
        }
    }
}
