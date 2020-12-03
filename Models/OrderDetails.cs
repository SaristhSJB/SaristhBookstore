using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaristhBookstore.Models
{
    public class OrderDetails
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int Quantity { get; set; }


        public int OrderId { get; set; }
        public string BookName { get; set; }
        public int Price { get; set; }
    }
}