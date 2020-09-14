namespace GoodsForAll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNormalUser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NormalUsers",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        locationX = c.Single(nullable: false),
                        locationY = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NormalUsers");
        }
    }
}
