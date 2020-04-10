namespace Participation5
{
  using System;
  using System.Collections.Generic;
  using System.ComponentModel.DataAnnotations;
  using System.ComponentModel.DataAnnotations.Schema;
  using System.Data.Entity.Spatial;

  //These are the columns in the db table
  [Table("Product")]
  public partial class Product
  {
    [Key]
    [StringLength(5)]
    [Required]
    public string Product_Number { get; set; }

    [Required]
    [StringLength(50)]
    public string Description { get; set; }

    public int Units_On_Hand { get; set; }

    [Column(TypeName = "money")]
    public decimal Price { get; set; }

    [StringLength(50)]
    public string Category { get; set; }
  }
}
