namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class latestupdae : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserModels", "ProfilePic", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserModels", "ProfilePic");
        }
    }
}
