using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModelPractice.Models
{
    public class PersonCreateVM
    {
        [Required(ErrorMessage = "Name Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email Required")]
        [EmailAddress]
        [Display(Name = "E-Mail")]
        [HotmailEmail("acme.com", ErrorMessage = "Must be of type @Ad.Se")]
        public string Email { get; set; }

        [Range(typeof(bool), "true", "true", ErrorMessage = "MUST ACCEPT TERMS")]
        [Display(Name = "I Accept terms and conditions")]
        public bool AcceptTerms { get; set; }
    }
}
