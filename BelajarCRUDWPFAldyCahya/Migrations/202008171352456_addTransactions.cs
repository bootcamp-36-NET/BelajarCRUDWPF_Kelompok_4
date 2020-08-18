namespace BelajarCRUDWPFAldyCahya.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTransactions : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TransactionItem",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Quantity = c.Int(nullable: false),
                        Transaction_Id = c.String(nullable: false, maxLength: 128),
                        Item_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Transaction", t => t.Transaction_Id, cascadeDelete: true)
                .ForeignKey("dbo.items", t => t.Item_Id, cascadeDelete: true)
                .Index(t => t.Transaction_Id)
                .Index(t => t.Item_Id);
            
            CreateTable(
                "dbo.Transaction",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        OrderDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TransactionItem", "Item_Id", "dbo.items");
            DropForeignKey("dbo.TransactionItem", "Transaction_Id", "dbo.Transaction");
            DropIndex("dbo.TransactionItem", new[] { "Item_Id" });
            DropIndex("dbo.TransactionItem", new[] { "Transaction_Id" });
            DropTable("dbo.Transaction");
            DropTable("dbo.TransactionItem");
        }
    }
}
