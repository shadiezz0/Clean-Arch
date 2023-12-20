using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoopy.Core.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        [EmailAddress]
        public string? Email { get; set; }
        public string? Phone { get; set; }

        public string? Address { get; set; }
        public List<Order>? Orders { get; set; }

    }
}
