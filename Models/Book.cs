using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SaristhBookstore.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public int Price { get; set; }

        [NotMapped]
        public int Quantity { get; set; }
        [NotMapped]

        public string Comment { get; set; }

        public bool IsFiction { get; set; }
        public DateTime CreatedDate { get; set; }



    }
}