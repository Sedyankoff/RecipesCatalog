namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsFavouriteFix : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Recipes", "IsFavourite", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Recipes", "IsFavourite");
        }
    }
}
