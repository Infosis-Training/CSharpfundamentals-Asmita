using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieManagement.Api.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MovieManagementApiContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MovieManagementApiContext") ?? throw new InvalidOperationException("Connection string 'MovieManagementApiContext' not found.")));


//builder.Services.AddCors(options =>
//{
//    options.AddPolicy(name: "movie",
//                      policy =>
//                      {
//                          policy.WithOrigins("https://localhost:7258");
//                      });
//});



// Add services to the container.

builder.Services.AddControllers();
//builder.Services.AddControllersWithViews();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(x =>
{
    x.AllowAnyHeader();
    x.AllowAnyOrigin();
    x.AllowAnyMethod();
} );

app.UseAuthorization();

app.MapControllers();

app.Run();
