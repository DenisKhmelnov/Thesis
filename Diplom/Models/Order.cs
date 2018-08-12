using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Diplom.Models
{
    public enum OrderStatus
    {
        WaitingForPayment,
        Sent,
        Received
    }
    public class Order
    {
        public int OrderId { get; set; }
        public virtual Customer CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public double OrderPrice { get; set; }
        public virtual List<CartItem> CartItems { get; set; }
    }
}