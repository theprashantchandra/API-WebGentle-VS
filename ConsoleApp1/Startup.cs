using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;

namespace ConsoleApp1
{
    public class Startup
    {
        public void ConfigurServices(IServiceCollection services)
        {
            services.AddControllers();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.Use(async (context, next) =>
            {
                await context.Response.WaitAsync("Hello from use-1 1 \n");

                await next();

                await context.Response.WaitAsync("Hello from use-1 2 \n");
            });

            app.Map("/nitesh", CutomCode);

            app.Use(async (context, next) =>
            {
                await context.Response.WaitAsync("Hello from use-2 1 \n");

                await next();

                await context.Response.WaitAsync("Hello from use-2 2 \n");
            });

            app.Run(async context =>
            {
                await context.Response.WriteAsync("Hello from Run 1");
            });

            app.Run(async context =>
            {
                await context.Response.WriteAsync("Hello from Run 2");
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();

            });
        }

        private void CutomCode(IApplicationBuilder app)
        {
            app.Use(async (context, next) =>
            {
                await context.Response.WiteAsync("Hello from Nitish \n");
            });
        }
    }
}
