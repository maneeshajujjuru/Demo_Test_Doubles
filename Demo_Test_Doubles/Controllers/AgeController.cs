using Demo_Test_Doubles.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_Test_Doubles.Controllers
{
    public class AgeController : Controller
    {
        private readonly IAge _ageService;

        public AgeController(IAge ageService)
        {
            _ageService = ageService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public string Get(int id)
        {
            return _ageService.Get(id);
        }

    }
}
