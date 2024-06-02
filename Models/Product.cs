using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

#nullable enable
namespace ElegantCoffeeImplementation.Models
{
    public class Product
    {

        [Key]
        public int ProductID { get; set; }

        [Display(Name = "Product Name")]
        [Required]
        public string ProductName { get; set; }

        [Display(Name = "Product Description")]
        public string? ProductDescription { get; set; }     

        [Display(Name = "Product Cost")]
        [Required(ErrorMessage = "You must enter a price.")]
        public decimal StartingPrice { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate
        {
            get
            {
                return DateTime.Now;
            }
        }

        [DataType((DataType.Date))]
        [Display(Name = "Auction End Date")]
        public DateTime EndDate { get; set; }

        public ICollection<Picture>? Pictures { get; set; }

        public ICollection<Bid>? Bids { get; }
    }
}