namespace GoodsForAll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedLocationColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NormalUsers", "location", c => c.String());
            AddColumn("dbo.Volunters", "location", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Volunters", "location");
            DropColumn("dbo.NormalUsers", "location");
        }
    }
}
