using AutoMapper;
using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Core.Entities;
using ClassroomHub.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassroomHub.Web.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;
        private readonly IMapper _mapper;

        public CourseController(ICourseService courseService, IMapper mapper)
        {
            _courseService = courseService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var entityCourses = _courseService.GetAll().ToList();
            var courses = _mapper.Map<List<CourseViewModel>>(entityCourses);
            return View(courses);
        }

        [HttpPost]
        public IActionResult Create(CourseViewModel model)
        {
            _courseService.Add(_mapper.Map<Course>(model));
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            var course = _courseService.GetById(id);
            var courseViewModel = _mapper.Map<CourseViewModel>(course);
            return View(courseViewModel);
        }

        [HttpPost]
        public IActionResult Edit(CourseViewModel model)
        {
            var courseEntity = _mapper.Map<Course>(model);
            _courseService.Update(courseEntity);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(Guid id)
        {
            _courseService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
