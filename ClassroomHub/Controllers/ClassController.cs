using AutoMapper;
using ClassroomHub.Core.Contracts.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ClassroomHub.Web.ViewModels;
using ClassroomHub.Core.Entities;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using ClassroomHub.Web.Models;
using ClassroomHub.Core.ApplicationExeception;

namespace ClassroomHub.Web.Controllers
{
    public class ClassController : Controller
    {
        private readonly IClassService _classService;
        private readonly ICourseService _courseService;
        private readonly IMapper _mapper;

        public ClassController(IClassService classService, IMapper mapper, ICourseService courseService)
        {
            _classService = classService;
            _mapper = mapper;
            _courseService = courseService;
        }

        public IActionResult Index()
        {
            var courses = _mapper.Map<List<CourseViewModel>>(_courseService.GetAll());
            ViewBag.Courses = new SelectList(courses, "Id", "Name");
            return View(new List<ClassViewModel>());
        }

        [HttpPost]
        public IActionResult Index(Guid id)
        {
            var courses = _mapper.Map<List<CourseViewModel>>(_courseService.GetAll());
            ViewBag.Courses = new SelectList(courses, "Id", "Name");
            var classes = _classService.GetAllByCourseId(id);
            var classesViewModel = _mapper.Map<IEnumerable<ClassViewModel>>(classes);
            return View(classesViewModel);
        }

        public IActionResult Create(ClassViewModel model)
        {
            try
            {
                var classEntity = _mapper.Map<Class>(model);
                _classService.Add(classEntity);
                return RedirectToAction(nameof(Index));

            }
            catch (InvalidDateExeception e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
        }

        [HttpGet]
        public IActionResult Update(Guid id)
        {
            var model = _mapper.Map<ClassViewModel>(_classService.GetById(id));
            var courses = _courseService.GetAll();
            ViewBag.Courses = new SelectList(courses, "Id", "Name");
            return View(model);
        }

        public IActionResult Update(ClassViewModel model)
        {
            var entity = _mapper.Map<Class>(model);
            _classService.Update(entity);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(Guid id)
        {
            _classService.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Error(string message)
        {
            var errorViewModel = new ErrorViewModel() { Message = message };
            return View(errorViewModel);
        }
    }
}
