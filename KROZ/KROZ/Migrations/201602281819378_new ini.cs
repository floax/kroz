namespace KROZ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newini : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Item", "Discriminator", c => c.String(maxLength: 128));
            DropColumn("dbo.Weapon", "AttackRate");
            DropColumn("dbo.Weapon", "MissedRate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Weapon", "MissedRate", c => c.Int(nullable: false));
            AddColumn("dbo.Weapon", "AttackRate", c => c.Int(nullable: false));
            DropColumn("dbo.Item", "Discriminator");
        }
    }
}
