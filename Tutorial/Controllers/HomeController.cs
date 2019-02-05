using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Linq;
using Tutorial.Model;
using Tutorial.Model.DTO;
using Tutorial.Services;

namespace Tutorial.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository<Student> _repository;
        public HomeController(IRepository<Student> repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            var list = _repository.GetAll();
            //使用DTO进行转换
            var vms = list.Select(x => new StudentInfoDTO
            {
                Id = x.stuId,
                Name = $"{x.stuFirstName}{x.stuLastName}",
                Age = DateTime.Now.Subtract(x.stuBirthDate).Days / 365
            });
            var vm = new HomeDTO {
                Students = vms
            };

            return View(vm);
        }

        public IActionResult Detail(int id)
        {
            var studen = _repository.GetById(id);
            if (studen == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(studen);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateStudent(StudentCreate student)
        {
            if (ModelState.IsValid)
            {
                var newStudent = new Student
                {
                    stuFirstName = student.stuFirstName,
                    stuLastName = student.stuLastName,
                    stuBirthDate = student.stuBirthDate,
                    stuGender = student.stuGender
                };
                var newModel = _repository.Add(newStudent);
                return RedirectToAction(nameof(Detail), new { id = newModel.stuId });

            }
            else
            {
                return View("Create");
            }
            
        }
    }
}