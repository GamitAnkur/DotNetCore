using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demo_dotnet_core
{
    public class CustomMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Custome Start \n");
            await next(context);
            await context.Response.WriteAsync("Custome End \n");
        }
    }
}
