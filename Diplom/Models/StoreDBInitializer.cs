using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Diplom.Models
{
    public class StoreDBInitializer:CreateDatabaseIfNotExists<FloverStoreDB>
    {
        protected override void Seed(FloverStoreDB db)
        {
            db.Products.Add(new Product
            {
                ProductName = "Роза",
                ProductPrice = 1.10M,
                ProductAmountOnStore = 10,
                ProductImage = "/Content/Images/placeholder.gif",
                ProductPictures = new List<ProductPicture>
                {
                    new ProductPicture(){ProductPictureUrl = "/Content/Images/placeholder.gif"},
                    new ProductPicture(){ProductPictureUrl = "/Content/Images/placeholder.gif"}
                }
            });
            db.Products.Add(new Product
            {
                ProductName = "Георгин",
                ProductPrice = 2.20M,
                ProductAmountOnStore = 15,
                ProductImage = "/Content/Images/placeholder.gif",
                ProductPictures = new List<ProductPicture>{
                    new ProductPicture(){ProductPictureUrl = "/Content/Images/placeholder.gif"},
                    new ProductPicture(){ProductPictureUrl = "/Content/Images/placeholder.gif"}
                }
            });
            db.Products.Add(new Product
            {
                ProductName = "Пион",
                ProductPrice = 3.30M,
                ProductAmountOnStore = 20,
                ProductImage = "/Content/Images/placeholder.gif",
                ProductPictures = new List<ProductPicture>{
                    new ProductPicture(){ProductPictureUrl = "/Content/Images/placeholder.gif"},
                    new ProductPicture(){ProductPictureUrl = "/Content/Images/placeholder.gif"}
                }
            });

            base.Seed(db);
        }
    }
}