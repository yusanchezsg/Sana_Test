using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShopSana.MODELS.Entities
{
    [Table("CATEGORIES")]
    public class Categories
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        [Column("ID", Order = 0)]
        public int CategoryId { get; set; }

        [Column("NAME", Order = 1)]
        public string CategoryName { get; set; }

        [Column("DESCRIPTION", Order = 2)]
        public string CategoryDescription { get; set; }

    }
}
