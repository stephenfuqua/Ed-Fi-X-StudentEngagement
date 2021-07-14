using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace MSDF.StudentEngagement.Web
{
 // this comment is just to try to trigger the pull request build.
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
