using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShopSana.MODELS.Entities
{
    [Table("PRODUCTCATEGORIES")]
    public class ProductCategories
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        [Column("ID", Order = 0)]
        public int ProductCategoriesId { get; set; }

        public int ProductID { get; set; }
        public int CategoryID { get; set; }

        [ForeignKey("ProductID")]
        public Products? Products { get; set; }

        [ForeignKey("CategoryID")]
        public Categories? Categories { get; set; }
    }
}
