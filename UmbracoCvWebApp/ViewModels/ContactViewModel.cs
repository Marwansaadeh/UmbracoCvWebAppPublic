using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UmbracoCvWebApp.ViewModels
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "The first name field is required")]
        [Display(Name = "First Name:")]
        public string FullName { get; set; }

      

        [Required]
        [EmailAddress(ErrorMessage = "You must provide a valid email address")]
        [Display(Name = "Email Address:")]
        public string EmailAddress { get; set; }

        [Required]
        [Display(Name = "Message:")]
        public string Message { get; set; }



    }
}