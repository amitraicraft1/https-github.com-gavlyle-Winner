using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace winner.Models
{
    public class SPAREModel
    {
        
        [Required(ErrorMessage = "Please enter your email.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter spare part number.")]
        public string SparePartNumber { get; set; }
        [Required(ErrorMessage = "Please enter upload file.")]
        public string File { get; set; }
    }
}