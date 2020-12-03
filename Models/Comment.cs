using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaristhBookstore.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string BookName { get; set; }

        public string Description { get; set; }
    }
}