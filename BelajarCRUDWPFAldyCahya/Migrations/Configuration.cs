namespace BelajarCRUDWPFAldyCahya.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BelajarCRUDWPFAldyCahya.Context.MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "BelajarCRUDWPFAldyCahya.Context.MyContext";
        }

        protected override void Seed(BelajarCRUDWPFAldyCahya.Context.MyContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
