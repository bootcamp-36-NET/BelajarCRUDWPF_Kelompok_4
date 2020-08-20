namespace BelajarCRUDWPFAldyCahya.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAttributSupplier : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.suppliers", "Email", c => c.String());
            AddColumn("dbo.suppliers", "Password", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.suppliers", "Password");
            DropColumn("dbo.suppliers", "Email");
        }
    }
}
