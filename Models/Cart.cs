using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaristhBookstore.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        public string Name { get; set; }
        public int BookId { get; set; }


        public string Code { get; set; }
        public int Price { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedDate { get; set; } = System.DateTime.Now;



    }
}