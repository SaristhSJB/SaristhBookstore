using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaristhBookstore.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}