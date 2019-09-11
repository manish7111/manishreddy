namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.AdminModels");
            AddColumn("dbo.AdminModels", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.AdminModels", "Email", c => c.String());
            AddPrimaryKey("dbo.AdminModels", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.AdminModels");
            AlterColumn("dbo.AdminModels", "Email", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.AdminModels", "Id");
            AddPrimaryKey("dbo.AdminModels", "Email");
        }
    }
}
