using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Diplom.Models
{
    public class ProductPicture
    {
        public int ProductPictureId { get; set; }
        public int ProductId { get; set; }
        public string ProductPictureUrl { get; set; }
    }
}