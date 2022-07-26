using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    public class CustomMiddleware1 : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.Write.Async("Hello from new file 1 \n");
            await next(context);
            await context.Response.Write.Async("Hello from new file 1 \n");
        }
    }
}
