namespace Commerce.Data.Database
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CommerceModel : DbContext
    {
        public CommerceModel()
            : base("name=DSN")
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductReview> ProductReview { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .Property(e => e.DiscountPercent)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .Property(e => e.ListPrice)
                .HasPrecision(18, 0);
        }
    }
}
