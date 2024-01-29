var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.UseStaticFiles();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);


app.Run();









/* string x = "ciao";
app.UseStaticFiles();
app.MapGet("/", () => x);
app.MapGet("/home", () => "home page prima"); */