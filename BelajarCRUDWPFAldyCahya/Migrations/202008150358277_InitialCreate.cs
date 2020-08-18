namespace BelajarCRUDWPFAldyCahya.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Int(nullable: false),
                        Stock = c.Int(nullable: false),
                        Supplier_Id = c.String(nullable: false, maxLength: 4),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.suppliers", t => t.Supplier_Id, cascadeDelete: true)
                .Index(t => t.Supplier_Id);
            
            CreateTable(
                "dbo.suppliers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 4),
                        Name = c.String(maxLength: 128),
                        JoinDate = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.items", "Supplier_Id", "dbo.suppliers");
            DropIndex("dbo.items", new[] { "Supplier_Id" });
            DropTable("dbo.suppliers");
            DropTable("dbo.items");
        }
    }
}
