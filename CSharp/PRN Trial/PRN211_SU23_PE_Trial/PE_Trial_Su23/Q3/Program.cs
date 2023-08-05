var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapControllerRoute(
    name: "default",
    pattern: "{Controller}/{Action}"
    );

app.MapControllerRoute(
    name: "action",
    pattern: "{Controller}/{Action}/{id?}"
    );



app.Run();
