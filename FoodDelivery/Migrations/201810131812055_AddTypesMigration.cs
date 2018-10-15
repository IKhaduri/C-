namespace FoodDelivery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTypesMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RestaurantType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Restaurant", "RestaurantType", c => c.Int(nullable: false));
            AddColumn("dbo.Restaurant", "Type_Id", c => c.Int());
            AlterColumn("dbo.Restaurant", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.Restaurant", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Restaurant", "LogoURL", c => c.String(nullable: false));
            CreateIndex("dbo.Restaurant", "Type_Id");
            AddForeignKey("dbo.Restaurant", "Type_Id", "dbo.RestaurantType", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Restaurant", "Type_Id", "dbo.RestaurantType");
            DropIndex("dbo.Restaurant", new[] { "Type_Id" });
            AlterColumn("dbo.Restaurant", "LogoURL", c => c.String());
            AlterColumn("dbo.Restaurant", "Name", c => c.String());
            AlterColumn("dbo.Restaurant", "Description", c => c.String());
            DropColumn("dbo.Restaurant", "Type_Id");
            DropColumn("dbo.Restaurant", "RestaurantType");
            DropTable("dbo.RestaurantType");
        }
    }
}
