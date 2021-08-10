using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Sujith_Web_Invent_Fashion.Models
{
    public class orderDetail
    {
        [Key]
        [HiddenInput]
        public int orderID { get; set; }

        [Required(ErrorMessage = "Please enter your name.")]
        [Display(Name = "Name")]
        public string name { get; set; }

        
        [Display(Name = "Model")]
        public string model { get; set; }

        [Required]
        [Display(Name = "Dress Size")]
        public string size { get; set; }

        [Display(Name = "Color")]
        public string color { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Order Date")]
        public DateTime OrderDate { get; set; }

    }
}
