using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShopSana.MODELS.Entities
{
    [Table("PRODUCTS")]
    public class Products
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        [Column("ID", Order = 0)]
        public int ProductId { get; set; }

        [Column("NAME", Order = 1)]
        public string ProductName { get; set; }

        [Column("DESCRIPTION", Order = 2)]
        public string ProductDescription { get; set; }

        [Column("PRICE", Order = 3)]
        public float ProductPrice { get; set; }


    }
}