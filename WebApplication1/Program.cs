var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//Chain multiple request delegates together with Use
app.Use(async(HttpContext context,RequestDelegate next)=>{

//before code
await context.Response.WriteAsync("Chain multiple request delegates together with Use");

await next.Invoke(context);

//after code

});


//Terminal middleware or short-circuting 
app.Run(async (HttpContext context) => {

    
     await context.Response.WriteAsync("Terminal middleware");

});

app.Run();
