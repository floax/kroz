namespace KROZ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inventaire : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Item", "Character_ID", "dbo.Character");
            DropIndex("dbo.Item", new[] { "Character_ID" });
            CreateTable(
                "dbo.Inventory",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Character", "inventory_ID", c => c.Int());
            AddColumn("dbo.Item", "Inventory_ID", c => c.Int());
            AddColumn("dbo.Item", "Inventory_ID1", c => c.Int());
            AddColumn("dbo.UsableItem", "Character_ID", c => c.Int());
            AddColumn("dbo.Weapon", "Character_ID", c => c.Int());
            CreateIndex("dbo.Character", "inventory_ID");
            CreateIndex("dbo.Item", "Inventory_ID");
            CreateIndex("dbo.Item", "Inventory_ID1");
            CreateIndex("dbo.UsableItem", "Character_ID");
            CreateIndex("dbo.Weapon", "Character_ID");
            AddForeignKey("dbo.Item", "Inventory_ID", "dbo.Inventory", "ID");
            AddForeignKey("dbo.Item", "Inventory_ID1", "dbo.Inventory", "ID");
            AddForeignKey("dbo.Character", "inventory_ID", "dbo.Inventory", "ID");
            AddForeignKey("dbo.UsableItem", "Character_ID", "dbo.Character", "ID");
            AddForeignKey("dbo.Weapon", "Character_ID", "dbo.Character", "ID");
            DropColumn("dbo.Item", "Character_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Item", "Character_ID", c => c.Int());
            DropForeignKey("dbo.Weapon", "Character_ID", "dbo.Character");
            DropForeignKey("dbo.UsableItem", "Character_ID", "dbo.Character");
            DropForeignKey("dbo.Character", "inventory_ID", "dbo.Inventory");
            DropForeignKey("dbo.Item", "Inventory_ID1", "dbo.Inventory");
            DropForeignKey("dbo.Item", "Inventory_ID", "dbo.Inventory");
            DropIndex("dbo.Weapon", new[] { "Character_ID" });
            DropIndex("dbo.UsableItem", new[] { "Character_ID" });
            DropIndex("dbo.Item", new[] { "Inventory_ID1" });
            DropIndex("dbo.Item", new[] { "Inventory_ID" });
            DropIndex("dbo.Character", new[] { "inventory_ID" });
            DropColumn("dbo.Weapon", "Character_ID");
            DropColumn("dbo.UsableItem", "Character_ID");
            DropColumn("dbo.Item", "Inventory_ID1");
            DropColumn("dbo.Item", "Inventory_ID");
            DropColumn("dbo.Character", "inventory_ID");
            DropTable("dbo.Inventory");
            CreateIndex("dbo.Item", "Character_ID");
            AddForeignKey("dbo.Item", "Character_ID", "dbo.Character", "ID");
        }
    }
}
