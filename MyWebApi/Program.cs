// using Serilog;

using Microsoft.EntityFrameworkCore;
using MyWebApi;

var builder = WebApplication.CreateBuilder(args);

// This below line is to configure the serilog package installed from nuget to log to a file
// Log.Logger = new LoggerConfiguration().MinimumLevel.Debug()
// .WriteTo.File("log/apiDevLogs.txt", rollingInterval: RollingInterval.Day).CreateLogger();

// // This below line is now telling the application to use serilog rather than the built in logger package
// builder.Host.UseSerilog();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<ApplicationDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultSQLConnection"));
});
builder.Services.AddControllers(option =>
{
    // option.ReturnHttpNotAcceptable = true;
}).AddNewtonsoftJson().AddXmlDataContractSerializerFormatters();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapControllers();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.Run();

