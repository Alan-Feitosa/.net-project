using AutoMapper;
using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Core.Entities;
using ClassroomHub.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ClassroomHub.Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        private readonly IClassService _classService;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public StudentController(IStudentService studentService, 
                                 IMapper mapper, 
                                 IClassService classService,
                                 IUserService userService)
        {
            _studentService = studentService;
            _mapper = mapper;
            _classService = classService;
            _userService = userService;
        }

        public IActionResult Index()
        {
            var classes = _classService.GetAll();
            var classesViewModel = _mapper.Map<List<ClassViewModel>>(classes);
            ViewBag.Classes = new SelectList(classesViewModel, "Id","Name");
            ViewBag.Users = new SelectList(_mapper.Map<List<UserViewModel>>(_userService.GetAll()),"Id", "UserName");
            var students = _studentService.GetAll();
            var studentViewModels = _mapper.Map<List<StudentViewModel>>(students);
            return View(studentViewModels);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(StudentViewModel model)
        {

            _studentService.Add(_mapper.Map<Student>(model));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            //GUID uuid
            //87932D11-AF2A-4D23-8F8A-6CD7BF33DF61
            return Ok();
        }
    }
}
