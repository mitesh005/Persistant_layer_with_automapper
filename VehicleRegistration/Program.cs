

using DatabaseLayer;
using DatabaseLayer.Context;
using Microsoft.EntityFrameworkCore;
using VehicleRegistration.Helper;
using VehicleRegistration.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var localConnectionString = builder.Configuration.GetConnectionString("localDbConnection");
builder.Services.AddDbContext<VehicleDbContext>(u => u.UseSqlServer(localConnectionString));
builder.Services.AddScoped<IVehicleService, VehicleService>();
//builder.Services.AddScoped<VehicleRepo,VehicleRepo>();
builder.Services.AddAutoMapper(typeof(AutoMappingProfile).Assembly);
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
    pattern: "{controller=Vehicle}/{action=GetAllVehicle}/{id?}");

app.Run();
