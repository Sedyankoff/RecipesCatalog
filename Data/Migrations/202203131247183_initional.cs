namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initional : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Name = c.String(),
                        Recipe_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Recipes", t => t.Recipe_Id)
                .Index(t => t.Recipe_Id);
            
            CreateTable(
                "dbo.Recipes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Recipe_Id", "dbo.Recipes");
            DropIndex("dbo.Products", new[] { "Recipe_Id" });
            DropTable("dbo.Recipes");
            DropTable("dbo.Products");
        }
    }
}
