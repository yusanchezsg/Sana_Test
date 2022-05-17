using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShopSana.MODELS.Models
{
    [Table("CUSTOMERS")]
    public class Customers
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        [Column("ID", Order = 0)]
        public int CustomerId { get; set; }

        [Column("FIRSTNAME", Order = 1)]
        public string CustomerFirstName { get; set; }

        [Column("LASTNAME", Order = 2)]
        public string CustomerLastName { get; set; }

        [Column("PHONE", Order = 3)]
        public string CustomerPhone { get; set; }
    }
}
