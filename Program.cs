var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapControllerRoute("default","{controller}/{action=Index}/{id?}");

app.Run();

