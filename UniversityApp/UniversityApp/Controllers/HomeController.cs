using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UniversityApp.Models;
using UniversityApp.ViewModels;

namespace UniversityApp.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
          
            List<Student> students = new List<Student>
            {
                new Student
                {
                    Id = 1,
                    GroupId = 1,
                    Name = "Hikmet",
                    Surname = "Abbasov",
                    Point = 67
                },
                 new Student
                {
                    Id = 2,
                    GroupId = 1,
                    Name = "Zakir",
                    Surname = "Haciyev",
                    Point = 17
                },
                  new Student
                {
                    Id = 3,
                    GroupId = 1,
                    Name = "Bextiyar",
                    Surname = "Abbasov",
                    Point = 57
                },
                   new Student
                {
                    Id = 4,
                    GroupId = 1,
                    Name = "Ibrahim",
                    Surname = "Sumqayitli",
                    Point = 51
                },
                    new Student
                {
                    Id = 5,
                    GroupId = 1,
                    Name = "Sugra",
                    Surname = "Kecmemisik",
                    Point = 27
                },
                     new Student
                {
                    Id = 6,
                    GroupId = 1,
                    Name = "Sunal",
                    Surname = "Jabiyev",
                    Point = 97
                }
            };
            List<Group> groups = new List<Group>
            {
                new Group
                {
                    Id = 1,
                    No = "P123"
                },
                new Group
                {
                    Id = 2,
                    No = "P124"
                },
                new Group
                {
                    Id = 3,
                    No = "BP201"
                },
                new Group
                {
                    Id = 4,
                    No = "BP202"
                },
            };

            HomeViewModel viewModel = new HomeViewModel
            {
                Students = students,
                Groups = groups
            };

            return View(viewModel);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Detail(int id)
        {
            ViewBag.Id = id;
            TempData["Id"] = id;

            return RedirectToAction("about");
            //return View();
        }

    }
}
