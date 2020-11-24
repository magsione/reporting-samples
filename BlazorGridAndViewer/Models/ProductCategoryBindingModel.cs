using Blazor_UI_and_Report_Viewer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_UI_and_Report_Viewer.Models
{
    public class ProductCategoryBindingModel
    {
        public static Func<ProductSubCategory, ProductCategoryBindingModel> ProductCategoryFunc = (productCategory) =>
        new ProductCategoryBindingModel
        {
            ProductSubCategoryId = productCategory.ProductSubCategoryId,
            Name = productCategory.Name,
            ParentProductCategoryId = productCategory.ParentProductCategory.ProductCategoryId,
            ParentProductCategoryName = productCategory.ParentProductCategory.Name
        };

        public int ProductSubCategoryId { get; set; }
        public int? ParentProductCategoryId { get; set; }
        public string Name { get; set; }
        public string ParentProductCategoryName { get; set; }
    }
}
