var builder = WebApplication.CreateBuilder(args);

//Add các service
builder.Services.AddControllersWithViews();
var app = builder.Build();


app.MapGet("/", () => "Hello World!");
//dinh nghia cac phan tich (Rounting) cho cac pattern url


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action}"
    );


app.MapControllerRoute(
    name: "course",
    pattern: "{controller}/{action}/{id?}"
    );

app.Run();
