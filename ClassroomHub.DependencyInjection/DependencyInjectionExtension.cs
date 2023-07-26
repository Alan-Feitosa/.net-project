using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Core.Contracts.Repositories;
using ClassroomHub.Data.Repositories;
using ClassroomHub.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ClassroomHub.DependencyInjection
{
    public static class DependencyInjectionExtension
    {
        public static void AddServicesDependency(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<ITeacherService, TeacherService>();
            services.AddScoped<IActivityService, ActivityService>();
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<IDeliveryService, DeliveryService>();
            services.AddScoped<IModuleService, ModuleService>();
            services.AddScoped<IClassService, ClassService>();
        }
       
        public static void AddRepositoryDependency(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<IClassRepository, ClassRepository>();
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<ITeacherRepository, TeacherRepository>();
            services.AddScoped<IModuleRepository, ModuleRepository>();
        }
    }
}
