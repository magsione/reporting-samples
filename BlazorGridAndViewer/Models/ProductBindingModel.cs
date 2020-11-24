using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_UI_and_Report_Viewer
{
    public class ProductBindingModel
    {
        public static Func<Product, ProductBindingModel> ProductFunc = (product) =>
            new ProductBindingModel
            {
                ProductId = product.ProductId,
                Name = product.Name,
                ProductNumber = product.ProductNumber,
                Color = product.Color,
                StandardCost = product.StandardCost,
                ListPrice = product.ListPrice,
                Size = product.Size,
                Weight = product.Weight,
                SellStartDate = product.SellStartDate,
                SellEndDate = product.SellEndDate,
                DiscontinuedDate = product.DiscontinuedDate,
                //ThumbNailPhoto = product.ThumbNailPhoto,
                //ThumbnailPhotoFileName = product.ThumbnailPhotoFileName,
                ModifiedDate = product.ModifiedDate,
                ProductCategoryId = product.ProductSubcategory.ParentProductCategory.ProductCategoryId,
                ProductCategoryName = product.ProductSubcategory.ParentProductCategory.Name,
                ProductSubCategoryId = product.ProductSubcategory.ProductSubCategoryId,
                ProductSubCategoryName = product.ProductSubcategory.Name
            };

        /*public Product GetProduct()
        {
            return new Product()
            {
                Name = Name,
                ProductNumber = ProductNumber ??
                    $"{Name.Substring(0, Math.Min(Name.Length, 3)).Trim().ToUpper()}-{new Random().Next(99)}",
                Color = Color,
                StandardCost = StandardCost,
                ListPrice = ListPrice,
                Size = Size,
                Weight = Weight,
                ProductCategoryId = ProductCategoryId,
                SellStartDate = SellStartDate,
                SellEndDate = SellEndDate,
                DiscontinuedDate = DiscontinuedDate,
                ThumbNailPhoto = ThumbNailPhoto,
                ModifiedDate = DateTime.UtcNow,
                Rowguid = Guid.NewGuid()
            };
        }

        public void PopulateProductForUpdate(Product productForUpdate)
        {
            productForUpdate.Name = Name ?? productForUpdate.Name;
            productForUpdate.ProductNumber = ProductNumber ??
                productForUpdate.ProductNumber ??
                $"{Name.Substring(0, 3).Trim().ToUpper()}-{new Random().Next(99)}";
            productForUpdate.Color = Color ?? productForUpdate.Color;
            productForUpdate.StandardCost = StandardCost == default ? productForUpdate.StandardCost : StandardCost;
            productForUpdate.ListPrice = ListPrice == default ? productForUpdate.ListPrice : ListPrice;
            productForUpdate.Size = Size ?? productForUpdate.Size;
            productForUpdate.Weight = Weight ?? productForUpdate.Weight;
            productForUpdate.ProductCategoryId = ProductCategoryId ?? productForUpdate.ProductCategoryId;
            productForUpdate.SellStartDate = SellStartDate == default ? productForUpdate.SellStartDate : SellStartDate;
            productForUpdate.SellEndDate = SellEndDate ?? productForUpdate.SellEndDate;
            productForUpdate.DiscontinuedDate = DiscontinuedDate ?? productForUpdate.DiscontinuedDate;
            productForUpdate.ThumbNailPhoto = ThumbNailPhoto ?? productForUpdate.ThumbNailPhoto;
            productForUpdate.ModifiedDate = DateTime.UtcNow;
        }*/

        public int ProductId { get; set; }

        public string Name { get; set; }

        public string ProductNumber { get; set; }

        public string Color { get; set; }

        public decimal StandardCost { get; set; }

        public decimal ListPrice { get; set; }

        public string Size { get; set; }

        public decimal? Weight { get; set; }

        public int? ProductCategoryId { get; set; }
        public int? ProductSubCategoryId { get; set; }

        public DateTime SellStartDate { get; set; } = DateTime.Today;

        public DateTime? SellEndDate { get; set; }

        public DateTime? DiscontinuedDate { get; set; }

        public byte[] ThumbNailPhoto { get; set; }

        public string ThumbnailPhotoFileName { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string ProductCategoryName { get; set; }
        public string ProductSubCategoryName { get; set; }

        public bool ActiveSelling =>
            SellStartDate < DateTime.UtcNow && (!SellEndDate.HasValue || SellEndDate > DateTime.UtcNow);
    }
}
