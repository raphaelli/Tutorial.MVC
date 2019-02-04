using Microsoft.AspNetCore.Mvc;
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
    }
}