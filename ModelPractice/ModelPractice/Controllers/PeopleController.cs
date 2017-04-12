using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelPractice.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ModelPractice.Controllers
{
    public class PeopleController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var people = DataManager.GetAllPeople();
            return View(people);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            if (!ModelState.IsValid)
                return View(person);

            DataManager.AddPerson(person);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var person = DataManager.GetPerson(id);
            return View(person);
        }

        [HttpPost]
        public IActionResult Update(Person person)
        {
            if (!ModelState.IsValid)
                return View(person);

            DataManager.UpdatePerson(person);
            return RedirectToAction(nameof(Index));
        }
    }
}
