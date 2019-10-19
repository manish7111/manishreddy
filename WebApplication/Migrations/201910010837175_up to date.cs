namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class uptodate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NotesModels", "Label", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.NotesModels", "Label");
        }
    }
}
