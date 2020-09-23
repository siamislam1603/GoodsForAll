namespace GoodsForAll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedItemModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false),
                        quantity = c.Int(nullable: false),
                        location = c.String(nullable: false),
                        date = c.DateTime(nullable: false),
                        NormalUserId = c.String(maxLength: 128),
                        DonationTypeId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.DonationTypes", t => t.DonationTypeId, cascadeDelete: true)
                .ForeignKey("dbo.NormalUsers", t => t.NormalUserId)
                .Index(t => t.NormalUserId)
                .Index(t => t.DonationTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "NormalUserId", "dbo.NormalUsers");
            DropForeignKey("dbo.Items", "DonationTypeId", "dbo.DonationTypes");
            DropIndex("dbo.Items", new[] { "DonationTypeId" });
            DropIndex("dbo.Items", new[] { "NormalUserId" });
            DropTable("dbo.Items");
        }
    }
}
