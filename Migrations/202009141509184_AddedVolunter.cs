namespace GoodsForAll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedVolunter : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Volunters",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        status = c.Boolean(nullable: true),
                        task = c.Boolean(nullable: true),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Volunters");
        }
    }
}
