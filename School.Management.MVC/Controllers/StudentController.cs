using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using School.Management.Core.Entities;
using School.Management.Services;

namespace School.Management.MVC.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService studentService;
        public StudentController(IStudentService _studentService)
        {
            try
            {
                studentService = _studentService;
            }
            catch(Exception ex)
            {

            }
        }
        public async System.Threading.Tasks.Task<IActionResult> IndexAsync()
        {
            var services = this.HttpContext.RequestServices;
            var classservice = (IClassService)services.GetService(typeof(IClassService));
            var classes = await classservice.GetAllAsync(0);


            List<SelectListItem> items = classes.ConvertAll(a =>
            {
                return new SelectListItem()
                {
                    Text = a.ClassName,
                    Value = a.ClassID.ToString(),
                    Selected = false
                };
            });
          
            ViewBag.classes = items;
            List<Student> listofstudent = await studentService.GetAllAsync(1);
            return View(listofstudent);
        }
        [HttpGet]
        [ActionName("Create")]
        public async Task<IActionResult> CreateGetAsync(Student student)
        {
            // studentService.Add(student);

            var services = this.HttpContext.RequestServices;
            var classservice = (IClassService)services.GetService(typeof(IClassService));
            var classes = await classservice.GetAllAsync(0);
            student.Class = null;
            ViewBag.Classes = classes;


            List<SelectListItem> items = classes.ConvertAll(a =>
            {
                return new SelectListItem()
                {
                    Text = a.ClassName,
                    Value = a.ClassID.ToString(),
                    Selected = false
                };
            });
            ViewBag.items = items;
            return View();
        }

        [HttpGet]        
        public async Task<ActionResult> EditAsync(int   id)
        {
            // Student student;
       
            Student student = await studentService.GetByIdAsync(id);
            return View(student); 
        }

        [HttpPost]
        public async Task<ActionResult> Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                await studentService.Update(student);
            }
            return View(student);
        }


        [HttpGet]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            // Student student;

            Student student = await studentService.GetByIdAsync(id);
            return View(student);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(int  id)
        {
            if (ModelState.IsValid)
            {
                Student student = await studentService.GetByIdAsync(id);
                View(student);
                await studentService.Delete(id);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ActionName("Create")]
        public async System.Threading.Tasks.Task<IActionResult> CreatePostAsync(Student student, List<SelectListItem> items)
   
        {
            string ClassSelected = Request.Form["ClassName"].ToString();
        
            var p = items;
            student.Class = new Class()
            {
                ClassID = Convert.ToInt32(ClassSelected),
                ClassName = "Std " + ClassSelected.ToString()
            };
            if (ModelState.IsValid)
            {
                await studentService.Add(student);
            }
            return View();
        }
    }
}
