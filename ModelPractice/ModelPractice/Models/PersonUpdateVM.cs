using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModelPractice.Models
{
    public class PersonUpdateVM
    {
        [Required(ErrorMessage = "Name Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email Required")]
        [EmailAddress]
        [Display(Name = "E-Mail")]
        [HotmailEmail("acme.com", ErrorMessage = "Must be of type @Ad.Se")]
        public string Email { get; set; }

        [Range(typeof(bool), "true", "true", ErrorMessage = "MUST BE SURE")]
        [Display(Name = "I want some changes in my life")]
        public bool AreYouSure { get; set; }
    }
}
