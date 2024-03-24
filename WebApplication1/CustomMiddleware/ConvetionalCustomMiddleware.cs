namespace WebApplication1;

public class ConvetionalCustomMiddleware
{

    private readonly RequestDelegate _next;

    public ConvetionalCustomMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext httpContext)
    {

       await httpContext.Response.WriteAsync("Convetional Middleware Class");

       await _next.Invoke(httpContext);

    }

}
