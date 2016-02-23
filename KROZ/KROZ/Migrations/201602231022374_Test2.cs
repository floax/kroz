namespace KROZ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Character", "Name", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Character", "Genre", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Character", "HP", c => c.Int(nullable: false));
            AddColumn("dbo.Character", "MaxHP", c => c.Int(nullable: false));
            AddColumn("dbo.Character", "Level", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Character", "Level");
            DropColumn("dbo.Character", "MaxHP");
            DropColumn("dbo.Character", "HP");
            DropColumn("dbo.Character", "Genre");
            DropColumn("dbo.Character", "Name");
        }
    }
}
