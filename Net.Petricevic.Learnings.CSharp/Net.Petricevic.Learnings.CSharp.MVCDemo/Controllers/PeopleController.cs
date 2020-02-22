using Net.Petricevic.Learnings.CSharp.MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Net.Petricevic.Learnings.CSharp.MVCDemo.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListPeople()
        {
            var people = new List<PersonModel>();

            people.Add(new PersonModel{FirstName = "Mario", LastName = "Petricevic", Age = 33});
            people.Add(new PersonModel { FirstName = "Marija", LastName = "Antunovic", Age = 30 });
            people.Add(new PersonModel { FirstName = "Danny", LastName = "Kid", Age = 2 });

            return View(people);
        }
    }
}