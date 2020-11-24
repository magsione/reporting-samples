using Blazor_UI_and_Report_Viewer.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_UI_and_Report_Viewer
{
    [Table("Product", Schema = "Production")]
    public partial class Product
    {
        public Product()
        {
        }

        [Key]
        [Column("ProductID")]
        public int ProductId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(25)]
        public string ProductNumber { get; set; }

        [StringLength(15)]
        public string Color { get; set; }

        [Column(TypeName = "money")]
        public decimal StandardCost { get; set; }

        [Column(TypeName = "money")]
        public decimal ListPrice { get; set; }

        [StringLength(5)]
        public string Size { get; set; }

        [Column(TypeName = "decimal(8, 2)")]
        public decimal? Weight { get; set; }

        [Column("ProductSubcategoryID")]
        public int? ProductSubcategoryID { get; set; }

        [Column("ProductModelID")]
        public int? ProductModelId { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime SellStartDate { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? SellEndDate { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? DiscontinuedDate { get; set; }

        //public byte[] ThumbNailPhoto { get; set; }

        //[StringLength(50)]
        //public string ThumbnailPhotoFileName { get; set; }

        [Column("rowguid")]
        public Guid Rowguid { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        
        [ForeignKey(nameof(ProductSubcategoryID))]
        public virtual ProductSubCategory ProductSubcategory { get; set; }
    }
}
