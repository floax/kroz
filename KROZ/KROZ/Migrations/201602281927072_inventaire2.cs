namespace KROZ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inventaire2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UsableItem", "Character_ID", "dbo.Character");
            DropForeignKey("dbo.Weapon", "Character_ID", "dbo.Character");
            DropIndex("dbo.UsableItem", new[] { "Character_ID" });
            DropIndex("dbo.Weapon", new[] { "Character_ID" });
            DropColumn("dbo.UsableItem", "Character_ID");
            DropColumn("dbo.Weapon", "Character_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Weapon", "Character_ID", c => c.Int());
            AddColumn("dbo.UsableItem", "Character_ID", c => c.Int());
            CreateIndex("dbo.Weapon", "Character_ID");
            CreateIndex("dbo.UsableItem", "Character_ID");
            AddForeignKey("dbo.Weapon", "Character_ID", "dbo.Character", "ID");
            AddForeignKey("dbo.UsableItem", "Character_ID", "dbo.Character", "ID");
        }
    }
}
