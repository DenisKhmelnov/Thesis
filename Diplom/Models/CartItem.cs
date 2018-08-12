using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Diplom.Models
{
    public class CartItem
    {
        public int CartItemId { get; set; }
        public Product CartProduct { get; set; }
        public int ProductQuantityt { get; set; }
    }
}