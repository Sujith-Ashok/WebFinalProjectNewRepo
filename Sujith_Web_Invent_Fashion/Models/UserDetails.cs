using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Sujith_Web_Invent_Fashion.Models
{
    public class UserDetails
    {
        [Key]
        [HiddenInput]
        public int userID { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Please enter valid email address.")]
        [Display(Name = "Email Address")]
        public string UserEmailId { get; set; }

        [Required(ErrorMessage = "Please enter your name.")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your gender.")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please enter valid mailing address.")]
        [Display(Name = "Mailing Address")]
        public string Address { get; set; }

        [Phone]
        [Required(ErrorMessage = "Please enter valid phone number.")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Birth Date")]
        public DateTime userBirthDay { get; set; }

        [Display(Name = "T shirt Size")]
        public string DressSize { get; set; }
    }
}
