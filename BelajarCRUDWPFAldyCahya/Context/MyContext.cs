using BelajarCRUDWPFAldyCahya.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
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
        public DbSet<Transaction> Transactions { set; get; }
        public DbSet<TransactionItem> TransactionItems { set; get; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>()
                .HasRequired<Supplier>(S => S.Supplier)
                .WithMany(S => S.Items).HasForeignKey<string>(I => I.Supplier_Id);

            modelBuilder.Entity<Item>()
                .HasMany<TransactionItem>(ti => ti.TransactionItems)
                .WithRequired(i => i.Item)
                .HasForeignKey<int>(i => i.Item_Id)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Supplier>()
                .HasMany<Item>(s => s.Items)
                .WithRequired(i => i.Supplier)
                .HasForeignKey<string>(i => i.Supplier_Id)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Transaction>()
                .HasMany<TransactionItem>(ti => ti.TransactionItems)
                .WithRequired(i => i.Transaction)
                .HasForeignKey<string>(i => i.Transaction_Id)
                .WillCascadeOnDelete();

            modelBuilder.Entity<TransactionItem>()
                .HasRequired<Transaction>(T => T.Transaction)
                .WithMany(T => T.TransactionItems).HasForeignKey<string>(ti => ti.Transaction_Id);

            
        }
        
        
    }
}
