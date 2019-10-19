namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdminLoginModels",
                c => new
                    {
                        Email = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Email);
            
            CreateTable(
                "dbo.AdminModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        LoginTime = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CollaboratorModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(maxLength: 128),
                        NoteId = c.Int(nullable: false),
                        SenderEmail = c.String(),
                        ReceiverEmail = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserModels", t => t.Email)
                .Index(t => t.Email);
            
            CreateTable(
                "dbo.UserModels",
                c => new
                    {
                        Email = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Password = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Email);
            
            CreateTable(
                "dbo.LabelModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(maxLength: 128),
                        Label = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserModels", t => t.Email)
                .Index(t => t.Email);
            
            CreateTable(
                "dbo.NotesLabelModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LableId = c.Int(nullable: false),
                        NoteId = c.Int(nullable: false),
                        Email = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserModels", t => t.Email)
                .Index(t => t.Email);
            
            CreateTable(
                "dbo.NotesModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(maxLength: 128),
                        Title = c.String(),
                        Description = c.String(),
                        CreatedDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        Reminder = c.String(),
                        IsArchive = c.Boolean(nullable: false),
                        IsTrash = c.Boolean(nullable: false),
                        IsPin = c.Boolean(nullable: false),
                        Color = c.String(),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserModels", t => t.Email)
                .Index(t => t.Email);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NotesModels", "Email", "dbo.UserModels");
            DropForeignKey("dbo.NotesLabelModels", "Email", "dbo.UserModels");
            DropForeignKey("dbo.LabelModels", "Email", "dbo.UserModels");
            DropForeignKey("dbo.CollaboratorModels", "Email", "dbo.UserModels");
            DropIndex("dbo.NotesModels", new[] { "Email" });
            DropIndex("dbo.NotesLabelModels", new[] { "Email" });
            DropIndex("dbo.LabelModels", new[] { "Email" });
            DropIndex("dbo.CollaboratorModels", new[] { "Email" });
            DropTable("dbo.NotesModels");
            DropTable("dbo.NotesLabelModels");
            DropTable("dbo.LabelModels");
            DropTable("dbo.UserModels");
            DropTable("dbo.CollaboratorModels");
            DropTable("dbo.AdminModels");
            DropTable("dbo.AdminLoginModels");
        }
    }
}
