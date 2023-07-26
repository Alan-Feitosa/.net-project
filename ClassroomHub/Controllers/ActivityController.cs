using ClassroomHub.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using System.Linq;
using ClassroomHub.Core.Contracts.Services;

namespace ClassroomHub.Web.Controllers
{
    public class ActivityController : Controller
    {
        List<ActivityToStudentViewModel> activities = new List<ActivityToStudentViewModel>()
        {
            //new ActivityToStudentViewModel()
            //{
            //    Title = "Criando a modelagem dos dados",
            //    Description = "Crie as classes necessárias para montar uma base de dado de acordo com oque foi dito em aula . Que se lasque se vc não lembra",
            //    ActivityScore = 50,
            //    DueDate = new DateTime(2023,05,24),
            //    TeacherName = "Thiago Ramos",
            //    ModuleName = "Projeto MVC com ASPNET"
            //},
            //new ActivityToStudentViewModel()
            //{
            //    Title = "Implemente o padrão repositorio",
            //    Description= "Crie o padrão repositorio seguindo as praticas de injeção de dependecia e inversão de controle estudas no modulo passado.",
            //    ActivityScore = 50,
            //    DueDate = new DateTime(2023,05,25),
            //    TeacherName = "Thiago Ramos",
            //    ModuleName = "Projeto MVC com ASPNET"
            //}
        };
        private readonly IActivityService _activityService;

        public ActivityController(IActivityService activityService)
        {
            _activityService = activityService;
        }
        public IActionResult Index()
        {
            
            ViewData["Teacher"] = activities.FirstOrDefault()?.TeacherName ?? "Sem professor";
            ViewData["ModuleName"] = activities.FirstOrDefault()?.ModuleName ?? "Sem modulo";
            return View(activities);
        }


    }
}
