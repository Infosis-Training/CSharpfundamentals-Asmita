using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MovieManagement.Data;

var builder = WebApplication.CreateBuilder(args);

//add connection string
var connectionString = builder.Configuration.GetConnectionString("devconnection") ?? throw new InvalidOperationException("Connection string 'devconnection' not found.");

builder.Services.AddDbContext<MovieManagementDb>(options =>
    options.UseSqlServer(connectionString));;

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDefaultIdentity<IdentityUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = true;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;

})
    .AddEntityFrameworkStores<MovieManagementDb>();
    builder.Services.AddControllersWithViews();
    builder.Services.AddRazorPages();


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

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapRazorPages();
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Movie}/{action=Index}/{id?}");
});


app.Run();