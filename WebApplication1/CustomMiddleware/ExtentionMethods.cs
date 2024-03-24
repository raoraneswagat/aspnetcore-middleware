using CustomMiddleware;

namespace WebApplication1;

public static class ExtentionMethods
{
      public static IApplicationBuilder UseUsingIMiddlewareInterface(this IApplicationBuilder app)
      {
         return app.UseMiddleware<UsingImiddlewareInterface>();
      }
}
