namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class latest : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NotesModels", "ReceiverEmail", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.NotesModels", "ReceiverEmail");
        }
    }
}
