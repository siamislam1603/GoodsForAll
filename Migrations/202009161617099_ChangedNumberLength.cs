namespace GoodsForAll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedNumberLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.NormalUsers", "phone", c => c.String(maxLength: 11));
            AlterColumn("dbo.Volunters", "phone", c => c.String(maxLength: 11));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Volunters", "phone", c => c.String());
            AlterColumn("dbo.NormalUsers", "phone", c => c.String());
        }
    }
}
