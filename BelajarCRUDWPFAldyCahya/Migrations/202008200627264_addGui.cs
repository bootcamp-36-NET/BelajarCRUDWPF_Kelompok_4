namespace BelajarCRUDWPFAldyCahya.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addGui : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.suppliers", "gId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.suppliers", "gId");
        }
    }
}
