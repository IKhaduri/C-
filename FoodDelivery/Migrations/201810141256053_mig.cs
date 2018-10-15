namespace FoodDelivery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Restaurant", "LogoURL", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Restaurant", "LogoURL", c => c.String());
        }
    }
}
