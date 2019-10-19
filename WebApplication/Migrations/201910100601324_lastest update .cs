namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lastestupdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AdminModels", "Service", c => c.String());
            AddColumn("dbo.UserModels", "Service", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserModels", "Service");
            DropColumn("dbo.AdminModels", "Service");
        }
    }
}
