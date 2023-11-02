/*
 * 
 * Ferramentas console nuget 
 * # add-migration P0001
 * # update-database
 * */

using Microsoft.EntityFrameworkCore;
using Processos.Models;




var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

String scon = builder.Configuration.GetConnectionString("DefaultConnection");

Console.WriteLine(scon);

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(scon));

// Especifica o caminho a sert utilizado
String wwwroot = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false, reloadOnChange: false).Build().GetValue<string>("AppSettings:documentroot");
		
if(wwwroot != null)
	Directory.SetCurrentDirectory(wwwroot);


builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
});

var app = builder.Build();
app.UseSession();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
