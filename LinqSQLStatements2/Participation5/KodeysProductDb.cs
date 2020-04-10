namespace Participation5
{
  using System;
  using System.Data.Entity;
  using System.ComponentModel.DataAnnotations.Schema;
  using System.Linq;

  // This is the db i'm bringing in
  public partial class KodeysProductDb : DbContext
  {
    public KodeysProductDb()
        : base("name=KodeysProductDb")
    {
    }

    public virtual DbSet<Product> Products { get; set; }
    
    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Product>()
          .Property(e => e.Product_Number)
          .IsFixedLength();

      modelBuilder.Entity<Product>()
          .Property(e => e.Price)
          .HasPrecision(19, 4);
    }
  }
}
