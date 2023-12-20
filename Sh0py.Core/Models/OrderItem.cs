using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoopy.Core.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        // Relationship: OrderItem belongs to a Product
        public int ProductId { get; set; }
        public Product Product { get; set; }

        // Relationship: OrderItem belongs to an Order
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
