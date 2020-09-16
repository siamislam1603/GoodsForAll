namespace GoodsForAll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DroppedColumnLocation : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.NormalUsers", "locationX");
            DropColumn("dbo.NormalUsers", "locationY");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NormalUsers", "locationY", c => c.Single(nullable: false));
            AddColumn("dbo.NormalUsers", "locationX", c => c.Single(nullable: false));
        }
    }
}
