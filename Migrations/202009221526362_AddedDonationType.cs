namespace GoodsForAll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDonationType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DonationTypes",
                c => new
                    {
                        id = c.Byte(nullable: false),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DonationTypes");
        }
    }
}
