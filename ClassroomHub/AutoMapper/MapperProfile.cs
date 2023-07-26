using AutoMapper;
using ClassroomHub.Core.Entities;
using ClassroomHub.Web.ViewModels;

namespace ClassroomHub.Web.AutoMapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        { 
            CreateMap<UserViewModel,User>()
                .ForMember(x => x.Email, src => src.MapFrom(x => x.UserName))
                .ForMember(x => x.Password, src => src.MapFrom(x => x.Password))
                .ReverseMap();

            CreateMap<CourseViewModel, Course>().ReverseMap();

            CreateMap<ClassViewModel, Class>().ReverseMap();

            CreateMap<StudentViewModel, Student>();

            CreateMap<Student, StudentViewModel>()
                .ForMember(x => x.Email, src => src.MapFrom(x => x.User.Email));

            CreateMap<TeacherViewModel, Teacher>()
                .ForMember(x => x.Especializacao, src => src.MapFrom(x => x.Especialization));

            CreateMap<Teacher, TeacherViewModel>()
                .ForMember(x => x.Email, src => src.MapFrom(x => x.User.Email))
                .ForMember(x => x.Especialization, src => src.MapFrom(x => x.Especializacao));

            CreateMap<ModuleViewModel, Module>()
                .ForMember(x => x.Nome, src => src.MapFrom(x => x.Name));

            CreateMap<Module, ModuleViewModel>()
                .ForMember(x => x.Name, src => src.MapFrom(s => s.Nome))
                .ForMember(x => x.TeacherName, src => src.MapFrom(x => x.Teacher.Name));
        }
    }
}
