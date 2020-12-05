using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using School.Management.Core.Entities;
using School.Management.Services;

namespace School.Management.MVC.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ITeacherService teacherService;     
        public TeacherController(ITeacherService _teacherService)
        {
            try
            {
                teacherService = _teacherService;
            }
            catch (Exception ex)
            {

            }
        }
        public async Task<IActionResult> Index()
        {
            int Yearid = 1;          
            var teachers =   await teacherService.GetAllAsync(1);
            ViewBag.Year = Yearid;
            return View(teachers);
        }

        [HttpGet]
        [Route("Teacher/Create")]
        public async Task<IActionResult> CreateAsync(Teacher teacher )
        {
            if (ModelState.IsValid)
            {
                var services = this.HttpContext.RequestServices;
                var classservice = (IClassService)services.GetService(typeof(IClassService));
                var classes = await classservice.GetAllAsync(0);
                teacher.classes = (List<Class>)classes;

            }
            return View(teacher);
        }

        [HttpPost]
        [Route("Teacher/Create")]
        public async Task<IActionResult> CreatePost(Teacher teacher , List<Class> classes)
        {
            teacher.classes = classes;
            if (ModelState.IsValid)
            {
                await teacherService.Add(teacher);
            }
            return RedirectToAction("Index");
        }

    }
}
