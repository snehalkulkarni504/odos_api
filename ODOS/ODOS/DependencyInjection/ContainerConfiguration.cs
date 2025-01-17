using ODOS.Interfaces;
using ODOS.Repositories;
namespace ODOS.DependencyInjection
{
    public static class ContainerConfiguration
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            //services.AddTransient<ITimebooking, TimebookingRepository>();
            services.AddTransient<IODOSInterface, ODOSRepository>();

        }
    }
}
