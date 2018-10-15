namespace FoodDelivery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NEW : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Restaurant", "Id", "dbo.RestaurantType");
            DropIndex("dbo.Restaurant", new[] { "Id" });
            DropPrimaryKey("dbo.Restaurant");
            AddColumn("dbo.Restaurant", "RestaurantTypeId", c => c.Int(nullable: false));
            AddColumn("dbo.RestaurantType", "TypeName", c => c.String());
            AlterColumn("dbo.Restaurant", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Restaurant", "Id");
            CreateIndex("dbo.Restaurant", "RestaurantTypeId");
            AddForeignKey("dbo.Restaurant", "RestaurantTypeId", "dbo.RestaurantType", "Id", cascadeDelete: true);
            DropColumn("dbo.Restaurant", "LogoURL");
            DropColumn("dbo.Restaurant", "RegisterTime");
            DropColumn("dbo.RestaurantType", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RestaurantType", "Type", c => c.String(nullable: false));
            AddColumn("dbo.Restaurant", "RegisterTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Restaurant", "LogoURL", c => c.String(nullable: false));
            DropForeignKey("dbo.Restaurant", "RestaurantTypeId", "dbo.RestaurantType");
            DropIndex("dbo.Restaurant", new[] { "RestaurantTypeId" });
            DropPrimaryKey("dbo.Restaurant");
            AlterColumn("dbo.Restaurant", "Id", c => c.Int(nullable: false));
            DropColumn("dbo.RestaurantType", "TypeName");
            DropColumn("dbo.Restaurant", "RestaurantTypeId");
            AddPrimaryKey("dbo.Restaurant", "Id");
            CreateIndex("dbo.Restaurant", "Id");
            AddForeignKey("dbo.Restaurant", "Id", "dbo.RestaurantType", "Id");
        }
    }
}
