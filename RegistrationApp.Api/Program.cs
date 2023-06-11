using Microsoft.EntityFrameworkCore;
using RegistrationApp.Core;
using RegistrationApp.Core.DataAccess;
using RegistrationApp.Core.Services;
using RegistrationApp.DataAccess;
using RegistrationApp.EntityFrameworkContext;
using RegistrationApp.Services;

var builder = WebApplication.CreateBuilder(args);

var Configuration = builder.Configuration;
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDBContext>(options =>
               options.UseSqlServer(Configuration.GetConnectionString("ConStr"),
               b => b.MigrationsAssembly(typeof(ApplicationDBContext).Assembly.FullName)), ServiceLifetime.Transient);

builder.Services.AddScoped<IApplicationDBContext>(provider => provider.GetService<ApplicationDBContext>());
builder.Services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IRegistrationServices, RegistrationServices>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
