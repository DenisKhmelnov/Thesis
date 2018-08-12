using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Diplom.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductAmountOnStore { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductImage { get; set; }
        public List<ProductPicture> ProductPictures { get; set; }
    }
}