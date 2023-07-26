using AutoMapper;
using ClassroomHub.Core.Contracts.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ClassroomHub.Web.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using ClassroomHub.Core.Entities;

namespace ClassroomHub.Web.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ITeacherService _teacherService;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public TeacherController(ITeacherService teacherService, IUserService userService, IMapper mapper)
        {
            _teacherService = teacherService;
            _userService = userService;
            _mapper = mapper;
        }


        // GET: TeacherController
        public ActionResult Index()
        {
            var users = _userService.GetAll();
            var usersViewModel = _mapper.Map<IEnumerable<UserViewModel>>(users);
            ViewBag.Users = new SelectList(usersViewModel, "Id", "UserName");
            var teachers = _teacherService.GetAll();
            var teacherViewModel = _mapper.Map<IEnumerable<TeacherViewModel>>(teachers);
            return View(teacherViewModel);
        }

        // GET: TeacherController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // POST: TeacherController/Create
        [HttpPost]        
        public ActionResult Create(TeacherViewModel model)
        {
            var teacher = _mapper.Map<Teacher>(model);
            _teacherService.Create(teacher);
            return RedirectToAction(nameof(Index));
        }

        // GET: TeacherController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TeacherController/Edit/5
        [HttpPost]        
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TeacherController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TeacherController/Delete/5
        [HttpPost]        
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
