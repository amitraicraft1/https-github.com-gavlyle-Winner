using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace winner.Models
{
    public class ProductdetailsModel
    {
        [Required(ErrorMessage = "Please enter your email.")]
        public string Email { get; set; }
        public string Message { get; set; }
        public int CARTRIDGESID { get; set; }
        public string  partno { get; set; }
    }
}