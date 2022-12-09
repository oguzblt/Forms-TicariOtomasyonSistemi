namespace TicariOtomasyon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sehirs", "Sehir_Id", c => c.Int());
            AddColumn("dbo.Musteris", "SehirId", c => c.Int());
            CreateIndex("dbo.Sehirs", "Sehir_Id");
            CreateIndex("dbo.Musteris", "SehirId");
            AddForeignKey("dbo.Sehirs", "Sehir_Id", "dbo.Sehirs", "Id");
            AddForeignKey("dbo.Musteris", "SehirId", "dbo.Sehirs", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Musteris", "SehirId", "dbo.Sehirs");
            DropForeignKey("dbo.Sehirs", "Sehir_Id", "dbo.Sehirs");
            DropIndex("dbo.Musteris", new[] { "SehirId" });
            DropIndex("dbo.Sehirs", new[] { "Sehir_Id" });
            DropColumn("dbo.Musteris", "SehirId");
            DropColumn("dbo.Sehirs", "Sehir_Id");
        }
    }
}
