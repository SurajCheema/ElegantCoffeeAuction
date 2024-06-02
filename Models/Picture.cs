using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace ElegantCoffeeImplementation.Models
{
    public class Picture
    {
        [Key]
        public int PictureID { get; set; }
        public string FilePath { get; set; }

        public Product Product { get; set; }
        public int ProductID { get; set; }
    }
}
