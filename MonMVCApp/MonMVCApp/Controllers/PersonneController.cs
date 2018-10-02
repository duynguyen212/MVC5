using MonMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MonMVCApp.Controllers
{
    public class PersonneController : Controller
    {
        // GET: Personne
        public ActionResult Index()
        {
            var p = new Personne
            {
                Nom = "Cristiano Ronaldo",
                Age = 33,
                Email = "cr7@juve.tus"
            };

            return View(p);
        }

        public ActionResult Liste()
        {
            var personnes = new List<Personne>
            {
                new Personne { Nom = "Lionel Messi", Age = 32, Email = "lionel@messi.bca"},
                new Personne { Nom = "Alexis Sanchez", Age = 32, Email = "alexis@sanchez.mu"},
                new Personne { Nom = "Eden Hazard", Age = 30, Email = "eden@chelsea.com"}
            };

            return View(personnes);
        }

        [HttpGet]
        public ActionResult Edit ()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(Personne p)
        {
            if (!ModelState.IsValid)
            {
                return View(p);
            }

            return null;
        }

        public ActionResult Grille()
        {
            var personnes = new List<Personne>
            {
                new Personne { Nom = "Lionel Messi", Age = 32, Email = "lionel@messi.bca"},
                new Personne { Nom = "Alexis Sanchez", Age = 32, Email = "alexis@sanchez.mu"},
                new Personne { Nom = "Jose Mourinho", Age = 52, Email = "lionel@messi.bca"},
                new Personne { Nom = "Zinedine Zidane", Age = 45, Email = "alexis@sanchez.mu"},
                new Personne { Nom = "Paulo Maldini", Age = 44, Email = "lionel@messi.bca"},
                new Personne { Nom = "Casanova", Age = 32, Email = "alexis@sanchez.mu"},
                new Personne { Nom = "Lionel Messi", Age = 32, Email = "lionel@messi.bca"},
                new Personne { Nom = "Kylian Mbappé", Age = 19, Email = "alexis@sanchez.mu"},
                new Personne { Nom = "Thomas Lémar", Age = 23, Email = "eden@chelsea.com"}
            };

            return View(personnes);
        }
    }
}