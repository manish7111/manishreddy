namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class last1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AdminModels", "NotesCount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AdminModels", "NotesCount");
        }
    }
}
