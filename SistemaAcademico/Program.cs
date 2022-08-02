using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SistemaAcademico.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<SistemaAcademicoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SistemaAcademicoContext") ?? throw new InvalidOperationException("Connection string 'SistemaAcademicoContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

//Build do banco de dados Sql
builder.Services.AddDbContext<SistemaAcademicoContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SistemaAcademicoContext")));



var app = builder.Build();

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
