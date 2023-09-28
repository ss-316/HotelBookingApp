<<<<<<< HEAD
=======
using HotelBookingApp.Data;
using HotelBookingApp.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

>>>>>>> 309619e (register setup)
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

<<<<<<< HEAD
=======
builder.Services.AddDbContext<HotelBookingDB>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("HotelBookingConnectionString")));
builder.Services.AddScoped<IRegistrationRepository,SQLRegistrationRepository>();
>>>>>>> 309619e (register setup)
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

<<<<<<< HEAD
=======

/*app.UseEndpoints(endpoints =>
{
    endpoints.MapRazorPages().DefaultPage("/Login");

});*/
>>>>>>> 309619e (register setup)
app.MapRazorPages();

app.Run();
