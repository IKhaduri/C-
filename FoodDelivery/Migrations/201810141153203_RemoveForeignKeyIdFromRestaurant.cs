namespace FoodDelivery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveForeignKeyIdFromRestaurant : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Restaurant", "RestaurantType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Restaurant", "RestaurantType", c => c.Int(nullable: false));
        }
    }
}
