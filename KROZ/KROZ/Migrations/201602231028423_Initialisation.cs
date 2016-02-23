namespace KROZ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialisation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Player", "XP", c => c.Int(nullable: false));
            AddColumn("dbo.Item", "Name", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.UsableItem", "RestoreHP", c => c.Int(nullable: false));
            AddColumn("dbo.UsableItem", "AttackBoost", c => c.Int(nullable: false));
            AddColumn("dbo.UsableItem", "DefenseBoost", c => c.Int(nullable: false));
            AddColumn("dbo.Weapon", "AttackRate", c => c.Int(nullable: false));
            AddColumn("dbo.Weapon", "MissedRate", c => c.Int(nullable: false));
            AddColumn("dbo.Map", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Map", "Name");
            DropColumn("dbo.Weapon", "MissedRate");
            DropColumn("dbo.Weapon", "AttackRate");
            DropColumn("dbo.UsableItem", "DefenseBoost");
            DropColumn("dbo.UsableItem", "AttackBoost");
            DropColumn("dbo.UsableItem", "RestoreHP");
            DropColumn("dbo.Item", "Name");
            DropColumn("dbo.Player", "XP");
        }
    }
}
