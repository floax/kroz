namespace KROZ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cell",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PosX = c.Int(nullable: false),
                        PosY = c.Int(nullable: false),
                        MoveTo = c.Boolean(nullable: false),
                        MonsterRate = c.Int(nullable: false),
                        Description = c.String(),
                        MonsterGroup = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Character",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        currentCell_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cell", t => t.currentCell_ID, cascadeDelete: true)
                .Index(t => t.currentCell_ID);
            
            CreateTable(
                "dbo.Item",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Character_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Character", t => t.Character_ID)
                .Index(t => t.Character_ID);
            
            CreateTable(
                "dbo.Map",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Monster",
                c => new
                    {
                        ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Character", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.Player",
                c => new
                    {
                        ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Character", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.UsableItem",
                c => new
                    {
                        ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Item", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.Weapon",
                c => new
                    {
                        ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Item", t => t.ID)
                .Index(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Weapon", "ID", "dbo.Item");
            DropForeignKey("dbo.UsableItem", "ID", "dbo.Item");
            DropForeignKey("dbo.Player", "ID", "dbo.Character");
            DropForeignKey("dbo.Monster", "ID", "dbo.Character");
            DropForeignKey("dbo.Item", "Character_ID", "dbo.Character");
            DropForeignKey("dbo.Character", "currentCell_ID", "dbo.Cell");
            DropIndex("dbo.Weapon", new[] { "ID" });
            DropIndex("dbo.UsableItem", new[] { "ID" });
            DropIndex("dbo.Player", new[] { "ID" });
            DropIndex("dbo.Monster", new[] { "ID" });
            DropIndex("dbo.Item", new[] { "Character_ID" });
            DropIndex("dbo.Character", new[] { "currentCell_ID" });
            DropTable("dbo.Weapon");
            DropTable("dbo.UsableItem");
            DropTable("dbo.Player");
            DropTable("dbo.Monster");
            DropTable("dbo.Map");
            DropTable("dbo.Item");
            DropTable("dbo.Character");
            DropTable("dbo.Cell");
        }
    }
}
