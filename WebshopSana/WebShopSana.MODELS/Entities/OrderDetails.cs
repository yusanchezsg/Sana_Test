using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShopSana.MODELS.Entities
{
    [Table("ORDERDETAILS")]
    public class OrderDetails
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        [Column("ID", Order = 0)]
        public int OrderDetailsId { get; set; }

        public int ProductID { get; set; }
        public int OrderID { get; set; }

        [ForeignKey("ProductID")]
        public Products? Products { get; set; }

        [ForeignKey("OrderID")]
        public Orders? Orders { get; set; }
    }
}
