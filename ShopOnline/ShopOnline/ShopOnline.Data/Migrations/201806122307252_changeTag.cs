namespace ShopOnline.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeTag : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "Tags");
            DropColumn("dbo.Slides", "Content");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Slides", "Content", c => c.String());
            AddColumn("dbo.Products", "Tags", c => c.String());
        }
    }
}
