using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace winner.Models
{
    public class DcEnquiryModel
    {


        
        public string Opration { get; set; }
        
        public string MotorSize { get; set; }
        
        public string VOLTAGE { get; set; }

        
        public string FLOWRATE { get; set; }
        
        public string PRESSURESETTING { get; set; }
        
        public string TYPEOFSYSTEM { get; set; }

        
        public string RESERVOIRSIZE { get; set; }
        
        public string POSITIONOFMOTOR { get; set; }
        
        public string PENDENT { get; set; }

        [Required(ErrorMessage = "Please enter your email.")]
        public string Email { get; set; }
       
       
        public string COMMENTS { get; set; }

    }
}