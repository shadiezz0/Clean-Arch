using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoopy.Core.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }

        // Relationship: Order belongs to a Customer
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }

        // Relationship: Order contains multiple OrderItems
        public List<OrderItem>? OrderItems { get; set; }
    }
}
