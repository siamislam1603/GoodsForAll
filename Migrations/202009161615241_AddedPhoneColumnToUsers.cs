namespace GoodsForAll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPhoneColumnToUsers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NormalUsers", "phone", c => c.String());
            AddColumn("dbo.Volunters", "phone", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Volunters", "phone");
            DropColumn("dbo.NormalUsers", "phone");
        }
    }
}
