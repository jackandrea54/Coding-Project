var builder = WebApplication.CreateBuilder(args);

// add
builder.Services.AddControllersWithViews();

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Student}/{action=Show}/{id?}"
    );

app.Run();
