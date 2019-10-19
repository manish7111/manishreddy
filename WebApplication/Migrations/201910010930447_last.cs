namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class last : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LabelModels", "LabelId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.LabelModels", "LabelId");
        }
    }
}
