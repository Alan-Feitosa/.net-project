using AutoMapper;
using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using ClassroomHub.Core.Entities;
using System;

namespace ClassroomHub.Web.Controllers
{
    public class ModuleController : Controller
    {
        private  readonly IModuleService _moduleService;
        private readonly ITeacherService _teacherService;
        private readonly IMapper _mapper;

        public ModuleController(IModuleService moduleService, IMapper mapper, ITeacherService teacherService)
        {
            _moduleService = moduleService;
            _mapper = mapper;
            _teacherService = teacherService;

        }

        public IActionResult Index()
        {
            var teachers = _mapper.Map<IEnumerable<TeacherViewModel>>(_teacherService.GetAll());
            ViewBag.Teachers = new SelectList(teachers, "Id", "Name");
            var modules = _moduleService.GetAll();
            var modulesViewModels = _mapper.Map<IEnumerable<ModuleViewModel>>(modules);
            return View(modulesViewModels);
        }

        public IActionResult Create(ModuleViewModel model)
        {
            var module = _mapper.Map<Module>(model);
            _moduleService.Add(module);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(Guid id)
        {
            var module = _mapper.Map<ModuleViewModel>(_moduleService.GetById(id));
            return View(module);
        }
    }
}
