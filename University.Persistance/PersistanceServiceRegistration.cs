using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using University.Domain.Contracts.Persistence;
using University.Persistance.Repositories;

namespace University.Persistance
{
    public static class PersistanceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddDbContext<UniversityDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("UniversityConnectionString")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(AsyncRepository<>));
            services.AddScoped<ILectorRepository, LectorRepository>();
            //services.AddScoped<IStudentRepository, StudentRepository>();
            //services.AddScoped<ISubjectRepository, SubjectRepository>();


            return services;
        }
    }
}
