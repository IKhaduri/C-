namespace FoodDelivery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFieldsToRestaurant : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Restaurant", "LogoURL", c => c.String(nullable:false));
            AddColumn("dbo.Restaurant", "RegisterTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Restaurant", "RegisterTime");
            DropColumn("dbo.Restaurant", "LogoURL");
        }
    }
}
