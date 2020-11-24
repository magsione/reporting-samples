using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_UI_and_Report_Viewer.Data
{
    [Table("ProductCategory", Schema = "Production")]
    public partial class ProductCategory
    {
        public ProductCategory()
        {
            SubCategories = new HashSet<ProductSubCategory>();
        }

        [Key]
        [Column("ProductCategoryID")]
        public int ProductCategoryId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<ProductSubCategory> SubCategories { get; set; }
    }
}
