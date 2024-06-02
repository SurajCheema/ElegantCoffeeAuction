using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace ElegantCoffeeImplementation.Models
{
    public class Bid
    {
        [Key]
        public int BidID { get; set; }
        public decimal BidAmount { get; set; }
        public DateTime BidTime { get; set; }

        public Product Product { get; set; }
        public int ProductID { get; set; }
    }
}
