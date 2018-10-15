namespace FoodDelivery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMenu : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FoodItem",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Double(nullable: false),
                        Time = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        FoodTypeId = c.Int(nullable: false),
                        RestaurantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FoodType", t => t.FoodTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Restaurant", t => t.RestaurantId, cascadeDelete: true)
                .Index(t => t.FoodTypeId)
                .Index(t => t.RestaurantId);
            
            CreateTable(
                "dbo.FoodType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FoodItem", "RestaurantId", "dbo.Restaurant");
            DropForeignKey("dbo.FoodItem", "FoodTypeId", "dbo.FoodType");
            DropIndex("dbo.FoodItem", new[] { "RestaurantId" });
            DropIndex("dbo.FoodItem", new[] { "FoodTypeId" });
            DropTable("dbo.FoodType");
            DropTable("dbo.FoodItem");
        }
    }
}
