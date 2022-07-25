using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;


namespace ConsoleApp1
{
    class Program
    {
        static void main(String[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        public static IHostBuilder CreateHostBuilder(String[] args)=>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webHost =>
                 {
                     webHost.UseStartup<Startup>();
                 });
    }
}

