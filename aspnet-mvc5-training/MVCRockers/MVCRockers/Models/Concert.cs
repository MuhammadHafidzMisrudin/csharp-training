using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCRockers.Models
{
    public class Concert
    {
        [Key] // Add a primary key.
        public string Id { get; set; } 

        // Add properties for Concert model class.
        [Required(ErrorMessage = "A Name field is required!")]
        [StringLength(20)]
        public string Name { get; set; }

        [Required(ErrorMessage = "A City field is required!")]
        public string City { get; set; }

        [Display(Name = "Concert Date")]
        //[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ConcertDate { get; set; }

        [Display(Name = "Backstage Passes")]
        public int Tickets { get; set; }

        [DataType(DataType.Currency)]
        public double Price { get; set; }

        [Display(Name = "Passcode")]
        [Required(ErrorMessage = "A Password field is required!")]
        [RegularExpression(@"\d{3,9}\w{3,9}", ErrorMessage = "Passcode must be 3-9 digits and 3-9 lower or upper case letters.")]
        public string Password { get; set; }

        public string PromoterName { get; set; }
    }
}