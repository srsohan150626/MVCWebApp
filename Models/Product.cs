using System;
using System.Collections.Generic;

namespace MVCWebApp.Models
{
    public partial class Product
    {
        public Product()
        {
            Orders = new HashSet<Order>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public decimal Price { get; set; }
        public string? ProductImage { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
