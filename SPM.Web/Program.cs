using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SPM.Web.Data;
using SPM.Web.Data.Jobs;

namespace SPM.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Build the host
            var host = CreateHostBuilder(args).Build();

            // Get the database service from the host
            using var scope = host.Services.CreateScope();
            var services = scope.ServiceProvider;
            var context = services.GetRequiredService<ApplicationDbContext>();

            // Start all jobs
            StartJobs.StartAllJobs(context).GetAwaiter().GetResult();

            // Run host
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    webBuilder.UseUrls("http://localhost:5100");
                });
        }
    }
}