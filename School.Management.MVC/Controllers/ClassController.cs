using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using School.Management.Services;

namespace School.Management.MVC.Controllers
{
    public class ClassController : Controller
    {
        private readonly IClassService classService;
        public ClassController(IClassService _classService )
        {
            try
            {
                classService = _classService;
            }
            catch (Exception ex)
            {

            }
        }
        public IActionResult Index()
        {
            return View();
        }
        [NonAction]
        public IActionResult FillClasses()
        {
           return (IActionResult)classService.GetAllAsync(0);
        }
    }
}
