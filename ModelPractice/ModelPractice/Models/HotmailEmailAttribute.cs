using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ModelPractice.Models
{
    class HotmailEmailAttribute : ValidationAttribute
    {
        // GET: /<controller>/
        string correctValue;
        public HotmailEmailAttribute(string correctValue)
        {
            this.correctValue = correctValue;
        }
        public override bool IsValid(object value)
        {
            if (value != null)
                return value.ToString().ToLower().EndsWith(correctValue);
            else
                return true;
        }
    }
}
