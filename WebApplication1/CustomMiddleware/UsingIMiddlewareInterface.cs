
namespace CustomMiddleware
{



    public class UsingImiddlewareInterface : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Using IMiddleware Interface");
            await next.Invoke(context);
        }
    }
}