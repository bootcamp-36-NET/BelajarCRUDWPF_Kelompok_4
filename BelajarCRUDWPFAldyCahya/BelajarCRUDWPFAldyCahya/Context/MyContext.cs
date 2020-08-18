using BelajarCRUDWPFAldyCahya.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarCRUDWPFAldyCahya.Context
{
    class MyContext : DbContext
    {
        public MyContext() : base("MyConnection")
        {

        }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Item> Items { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>()
                .HasRequired<Supplier>(S => S.Supplier)
                .WithMany(S => S.Items).HasForeignKey<string>(I => I.Supplier_Id);

            modelBuilder.Entity<Supplier>()
                .HasMany<Item>(s => s.Items)
                .WithRequired(i => i.Supplier)
                .HasForeignKey<string>(i => i.Supplier_Id)
                .WillCascadeOnDelete();
        }
    }
}
