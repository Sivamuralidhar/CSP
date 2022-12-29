
global using CSP.Server.Data;
global using CSP.Shared;
global using Microsoft.EntityFrameworkCore;
using BlazorStrap;
using CSP.Server.Services.CSProfile;
using CSP.Server.Services.GeekProfile;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IGeekProfileService, GeekProfileService>();
builder.Services.AddScoped<ICorporateServiceProviderProfileService, CSProfileService>();
builder.Services.AddBlazorStrap();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
}

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
