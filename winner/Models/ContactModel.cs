using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace winner.Models
{
    public class ContactModel
    {
        [Required(ErrorMessage="Please enter your name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your email.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone.")]
        public string phone { get; set; }
        
        public string Message { get; set; }
    }
}