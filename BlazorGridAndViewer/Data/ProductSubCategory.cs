using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_UI_and_Report_Viewer.Data
{
    [Table("ProductSubCategory", Schema = "Production")]
    public partial class ProductSubCategory
    {
        public ProductSubCategory()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        [Column("ProductSubCategoryID")]
        public int ProductSubCategoryId { get; set; }
        [Column("ProductCategoryID")]
        public int ProductCategoryId { set; get; }
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        [ForeignKey(nameof(ProductCategoryId))]
        public virtual ProductCategory ParentProductCategory { get; set; }

    }
}
