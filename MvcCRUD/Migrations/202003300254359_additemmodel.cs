namespace MvcCRUD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class additemmodel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TB_M_Item",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Price = c.Int(nullable: false),
                        Stock = c.Int(nullable: false),
                        SupplierId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_M_Supplier", t => t.SupplierId, cascadeDelete: true)
                .Index(t => t.SupplierId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TB_M_Item", "SupplierId", "dbo.TB_M_Supplier");
            DropIndex("dbo.TB_M_Item", new[] { "SupplierId" });
            DropTable("dbo.TB_M_Item");
        }
    }
}
