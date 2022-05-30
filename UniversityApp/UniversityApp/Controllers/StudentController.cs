using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UniversityApp.Models;

namespace UniversityApp.Controllers
{
    public class StudentController : Controller
    { 
        public IActionResult Detail(int id)
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

            var std = students.Find(x => x.Id == id);

            return View(std);
        }
    }
}
