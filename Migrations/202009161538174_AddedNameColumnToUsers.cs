namespace GoodsForAll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNameColumnToUsers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NormalUsers", "name", c => c.String(maxLength: 32));
            AddColumn("dbo.Volunters", "name", c => c.String(maxLength: 32));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Volunters", "name");
            DropColumn("dbo.NormalUsers", "name");
        }
    }
}
