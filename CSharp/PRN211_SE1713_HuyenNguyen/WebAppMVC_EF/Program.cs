namespace WebAppMVC_EF
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Product}/{action=Index}/{id?}"
                );
            app.Run();
        }
    }
}