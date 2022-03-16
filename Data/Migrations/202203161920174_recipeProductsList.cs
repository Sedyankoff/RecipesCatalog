namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class recipeProductsList : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Recipe_Id", c => c.Int());
            CreateIndex("dbo.Products", "Recipe_Id");
            AddForeignKey("dbo.Products", "Recipe_Id", "dbo.Recipes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Recipe_Id", "dbo.Recipes");
            DropIndex("dbo.Products", new[] { "Recipe_Id" });
            DropColumn("dbo.Products", "Recipe_Id");
        }
    }
}
