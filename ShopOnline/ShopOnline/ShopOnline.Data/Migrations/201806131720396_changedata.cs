namespace ShopOnline.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedata : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Tags", c => c.String());
            DropColumn("dbo.Products", "Tag");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Tag", c => c.String());
            DropColumn("dbo.Products", "Tags");
        }
    }
}
