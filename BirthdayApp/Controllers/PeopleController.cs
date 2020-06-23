using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using BirthdayApp.Models;
using BirthdayApp.Repository;


namespace BirthdayApp.Controllers
{
    public class PeopleController : Controller
    {
        private PeopleRepository PeopleRepository { get; set; }

        public PeopleController(PeopleRepository peopleRepository)
        {
            this.PeopleRepository = peopleRepository;
        }

        public static List<People> People { get; set; } = new List<People>();

        public IActionResult Index(string? message, string? type)
        {
            // READ
            var today = DateTime.Today;
            var todayBirthdays = this.PeopleRepository.GetAll().Where(person => person.Birthday.Day.Equals(today.Day) && person.Birthday.Month.Equals(today.Month));
            var birthdaysOrderby = this.PeopleRepository.GetAll().OrderBy(person => person.NextBirthday());

            ViewBag.todayBirthdays = todayBirthdays;
            ViewBag.birthdaysOrderBy = birthdaysOrderby;
            ViewBag.message = message;
            ViewBag.type = type;
            return View();
        }
        public IActionResult New()
        {
            return View();
        }

        public IActionResult Search()
        {
            return View();
        }

        public ActionResult Result([FromQuery] string query)
        {
            var model = this.PeopleRepository.SearchPeople(query);
            return View(model);
        }

        public IActionResult Edit([FromQuery] Guid id)
        {
            var people = PeopleRepository.GetById(id);

            return View(people);
        }
        public IActionResult Delete([FromQuery] Guid id)
        {
            var people = PeopleRepository.GetById(id);
            return View(people);
        }

        [HttpPost]
        public IActionResult Save(People model)
        {
            if (ModelState.IsValid == false)
                return View();

            //Criando identificador unico
            model.Id = Guid.NewGuid();

            //Adicionando na "Tabela"
            PeopleRepository.Save(model);

            return RedirectToAction("Index", "People", new { message = "Successfully registered person." });
        }
        [HttpPost]
        public IActionResult SaveEdit(Guid id, People model)
        {
            if (ModelState.IsValid == false)
                return View();

            var peopleEdit = PeopleRepository.GetById(id);

            peopleEdit.FirstName = model.FirstName;
            peopleEdit.LastName = model.LastName;
            peopleEdit.Birthday = model.Birthday;

            PeopleRepository.Update(peopleEdit);

            return RedirectToAction("Index", "People", new { message = "Successfully edited person." });
        }

        [HttpPost]
        public IActionResult DeletePeople(Guid id)
        {
            if (ModelState.IsValid == false)
                return View();

            PeopleRepository.Delete(id);

            return RedirectToAction("Index", "People", new { message = "Successfully deleted person." });
        }       
    }
}

