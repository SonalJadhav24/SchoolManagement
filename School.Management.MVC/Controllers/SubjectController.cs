using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using School.Management.Core.Entities;
using School.Management.Services;

namespace School.Management.MVC.Controllers
{
    public class SubjectController : Controller
    {
        private readonly ISubjectService  subjectService;
     

        public SubjectController(ISubjectService _subjectService)
        {
            try
            {
                subjectService = _subjectService;
            }
            catch (Exception ex)
            {

            }
        }

        public async Task<IActionResult> Index()
        {
            int Yearid = 1;          
            var Subjects =   await   subjectService.GetAllAsync(Yearid);
            ViewBag.Year = Yearid;
            return View(Subjects);
        }
        [HttpGet]
        [Route("Subject/Create")]
        public async Task<IActionResult> CreateAsync(Subject subject)
        {
            if (ModelState.IsValid)
            {
                var services = this.HttpContext.RequestServices;
                var classservice = (IClassService)services.GetService(typeof(IClassService));
                var classes = await classservice.GetAllAsync(0);
                subject.classes = (IList<Class>)classes;

            }        
            return View(subject);
        }   

        [HttpPost]
        [Route("Subject/Create")]
        public async Task<IActionResult> CreatePost(Subject subject, List<Class> classes)
        {
            subject.classes = classes;
            if (ModelState.IsValid)
            {
                await subjectService.Add(subject);
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<ActionResult> Edit(int id)
        {
            Subject subject = await subjectService.GetByIdAsync(id);
            return View(subject);
        }

        [HttpPost]
        [Route("Subject/Edit")]
        public async Task<ActionResult> Edit(Subject subject, List<Class> classes)
        {
            if (ModelState.IsValid)
            {
                subject.classes = classes;
                   await subjectService.Update(subject);
            }
            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            // Student student;

            Subject subject = await subjectService.GetByIdAsync(id);
            return View(subject);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(int id)
        {
            if (ModelState.IsValid)
            {
                Subject subject = await subjectService.GetByIdAsync(id);
               
                await subjectService.Delete(id);
            }
            return RedirectToAction("Index");
        }

    }
}
