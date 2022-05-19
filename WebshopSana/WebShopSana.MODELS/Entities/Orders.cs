using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShopSana.MODELS.Entities
{
    [Table("ORDERS")]
    public class Orders
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        [Column("ID", Order = 0)]
        public int OrderId { get; set; }

        public int CustomerId { get; set; }
        
        [ForeignKey("CustomerId")]
        public Customers? Customers { get; set; }
    }
}
