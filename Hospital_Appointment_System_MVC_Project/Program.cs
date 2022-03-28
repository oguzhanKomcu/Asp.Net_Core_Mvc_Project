
using Hospital_Appointment_System_MVC_Project.Infrastructure;
using Hospital_Appointment_System_MVC_Project.Infrastructure.EntityTypeConfiguration.Repositories.Concrete;
using Hospital_Appointment_System_MVC_Project.Infrastructure.EntityTypeConfiguration.Repositories.Interface;
using Hospital_Appointment_System_MVC_Project.Infrastructure.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// appdbcontext nesnemin  yaratýlmasý için 
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer
(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IPatientRepo, PatientRepo>();
builder.Services.AddScoped<IAppointmentRepo, AppointmentRepo>();
builder.Services.AddScoped<IDoctorRepo, DoctorRepo>();
builder.Services.AddScoped<IPatientService, PatientService>();
builder.Services.AddScoped<IDoctorService, DoctorService>();
builder.Services.AddScoped<IAppointmentService, AppointmentService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
