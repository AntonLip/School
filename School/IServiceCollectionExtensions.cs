using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using School.DataAccess;
using School.Models.DbModels;
using School.Models.Interfaces.IRepository;
using School.Models.Interfaces.IService;
using School.Services;

namespace School
{
    public static class IServiceCollectionExtensions
    {
        public static void AddIdentityConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataAccess.DbContext>(options =>
                 options.UseSqlServer(GetConnectionString(configuration)));

            // добавление сервисов Idenity
            services.AddIdentity<AppUser, IdentityRole>()
                    .AddEntityFrameworkStores<DataAccess.DbContext>();
        }

        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IGradeRepository, GradeRepository>();
            services.AddTransient<ITimetableRepository, TimetableRepository>();
            services.AddTransient<IDisciplinesRepository, DisciplineRepository>();

        }

        public static void AddServices(this IServiceCollection services)
        {
            services.AddTransient<IGradeService, GradeService>();
            services.AddTransient<ITimetableService, TimetableService>();
            services.AddTransient<IDisciplineService, DisciplineService>();
        }

        private static string GetConnectionString(IConfiguration configuration)
        {
            bool isHome = bool.Parse(configuration["Place:IsHome"]);
            if (isHome)
            {
                return configuration["ConnectionString:Str"];
            }
            var dbServer = configuration["DbSettings:DbServer"];
            var dbPort = configuration["DbSettings:DbPort"];
            var dbUser = configuration["DbSettings:DbUser"];
            var dbPassword = configuration["DbSettings:DbPassword"];
            var database = configuration["DbSettings:Database"];
            return $"Server={dbServer},{dbPort};Database={database};User Id={dbUser};Password={dbPassword};";
        }
    }

}
