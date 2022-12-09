namespace TicariOtomasyon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Sehirs", "Sehir_Id", "dbo.Sehirs");
            DropIndex("dbo.Sehirs", new[] { "Sehir_Id" });
            DropColumn("dbo.Sehirs", "Sehir_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sehirs", "Sehir_Id", c => c.Int());
            CreateIndex("dbo.Sehirs", "Sehir_Id");
            AddForeignKey("dbo.Sehirs", "Sehir_Id", "dbo.Sehirs", "Id");
        }
    }
}
