using CustomMiddleware;
using WebApplication1;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<UsingImiddlewareInterface>();

var app = builder.Build();

//Chain multiple request delegates together with Use
app.Use(async(HttpContext context,RequestDelegate next)=>{

//before code
await context.Response.WriteAsync("Chain multiple request delegates together with Use");

await next.Invoke(context);

//after code

});

//Call custom middleware
//app.UseMiddleware<UsingImiddlewareInterface>();

//call custom middleware using extention method

app.UseUsingIMiddlewareInterface();

//Call Conventional middleware

app.UseConvetionalCustomMiddleware();

//Terminal middleware or short-circuting 
app.Run(async (HttpContext context) => {

    
     await context.Response.WriteAsync("Terminal middleware");

});

app.Run();
