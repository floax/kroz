namespace KROZ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Map", "Cell_ID", c => c.Int());
            CreateIndex("dbo.Map", "Cell_ID");
            AddForeignKey("dbo.Map", "Cell_ID", "dbo.Cell", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Map", "Cell_ID", "dbo.Cell");
            DropIndex("dbo.Map", new[] { "Cell_ID" });
            DropColumn("dbo.Map", "Cell_ID");
        }
    }
}
