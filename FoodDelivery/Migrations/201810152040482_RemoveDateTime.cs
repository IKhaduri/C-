namespace FoodDelivery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveDateTime : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Restaurant", "RegisterTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Restaurant", "RegisterTime", c => c.DateTime(nullable: false));
        }
    }
}
