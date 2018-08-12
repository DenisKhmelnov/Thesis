using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Diplom.Models
{
    public class StorePosition
    {
        public int StorePositionId { get; set; }
        public int ProductId { get; set; }
        public int AmountOfProduct { get; set; }
    }
}