namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NotesModels", "SenderEmail", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.NotesModels", "SenderEmail");
        }
    }
}
