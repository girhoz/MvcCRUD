namespace MvcCRUD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addsuppliermodel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TB_M_Supplier",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TB_M_Supplier");
        }
    }
}
