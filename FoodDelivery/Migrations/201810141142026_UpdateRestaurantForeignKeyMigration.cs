namespace FoodDelivery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateRestaurantForeignKeyMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Restaurant", "RegisterTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Restaurant", "RegisterTime", c => c.DateTime(nullable: false));
        }
    }
}
