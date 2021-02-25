using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; }
        public string AuthFirst { get; set; }
        public string AuthLast { get; set; }
        public string Publisher { get; set; }

        [RegularExpression(@"^(978)?\d{9}(\d|X)$)")]
        public Int64 ISBN { get; set; }
        public String Classif { get; set; }
        public String Category { get; set; }
        public double Price { get; set; }
    }

  
  
}
