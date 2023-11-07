var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

string x = "ciao";

app.UseStaticFiles();

app.MapGet("/", () => x);

app.MapGet("/home", () => "home page");

app.Run();

