using System;
using System.Collections.Generic;

namespace NewWeb.Models
{
    public partial class Salesman1
    {
        public Salesman1()
        {
            Products = new HashSet<Product>();
        }

        public int Sid { get; set; }
        public string Sname { get; set; }
        public string City { get; set; }
        public int? CreditLimit { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
