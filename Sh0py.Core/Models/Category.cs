using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoopy.Core.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required]
        public string? Name { get; set; }

        public List<Product>? Products { get; set; }
    }
}
