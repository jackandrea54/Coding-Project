var builder = WebApplication.CreateBuilder(args);

//Add service
builder.Services.AddControllersWithViews();

var app = builder.Build();

//Dinh nghia cach phan tich (routing) cho cac pattern url

app.MapGet("/", () => "Hello World!");

app.MapControllerRoute(
    name: "default",
    pattern: "{Controller}/{Action=Index}"
    );



app.Run();
