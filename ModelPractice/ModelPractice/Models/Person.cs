using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModelPractice.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name Required")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Email Required")]
        [EmailAddress(ErrorMessage = "Wrongly formatted email")]
        [Display(Name = "E-Mail")]
        public string Email { get; set; }
    }
}
