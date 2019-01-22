﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCRockers.Models
{
    public class Concert
    {
        // Add properties for Concert model class.
        [Required(ErrorMessage = "A Name field is required!")]
        [StringLength(20)]
        public string Name { get; set; }

        [Required(ErrorMessage = "A City field is required!")]
        public string City { get; set; }

        [Display(Name = "Concert Date")]
        public DateTime ConcertDate { get; set; }

        [Display(Name = "Backstage Passes")]
        public int Tickets { get; set; }

        [DataType(DataType.Currency)]
        public double Price { get; set; }

        [Required(ErrorMessage = "A Password field is required!")]
        [RegularExpression(@"\d{3,9}\w{3,9}")]
        public string Password { get; set; }
    }
}