using Microsoft.AspNetCore.Mvc;
using System;
using Tutorial.Model;
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
            
            return View(list);
        }
    }
}