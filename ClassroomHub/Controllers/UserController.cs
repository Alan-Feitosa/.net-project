using ClassroomHub.Core.Entities;
using ClassroomHub.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using System.Collections.Generic;
using ClassroomHub.Core.Contracts.Services;
using System;

namespace ClassroomHub.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _mapper = mapper;
            _userService = userService;
        }
        public IActionResult Index()
        {
            var users = _userService.GetAll();
            var userViewModel = _mapper.Map<List<UserViewModel>>(users); 
            return View(userViewModel);            
        }

        public IActionResult Create(UserViewModel model)
        {
            var user = _mapper.Map<User>(model);
            _userService.Create(user);

            if (model.IsTeacher)
            {
                return RedirectToAction(nameof(Index), "Teacher");
            }
            return RedirectToAction(nameof(Index),"Student");
        }

        [HttpGet]
        public IActionResult Update(Guid id)
        {
            var model = _mapper.Map<UserViewModel>(_userService.GetById(id));
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(UserViewModel model) 
        {
            _userService.Update(_mapper.Map<User>(model));
            return RedirectToAction(nameof(Index));
        }
    }
}
