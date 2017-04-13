using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModelPractice.Models
{
    public class PeopleIndexVM
    {
        [Display(Name = "First Name")]
        public string Name { get; set; }
        [Display(Name = "E-Mail")]
        public string Email { get; set; }
        public bool ShowAsHighlighted { get; set; }
        public int Id { get;}

        public PeopleIndexVM(int id)
        {
            Id = id;
        }
    }
}
