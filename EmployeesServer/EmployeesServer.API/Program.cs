using EmployeesServer.API;
using EmployeesServer.Core;
using EmployeesServer.Core.Repositories;
using EmployeesServer.Core.Services;
using EmployeesServer.Data;
using EmployeesServer.Data.Repositories;
using EmployeesServer.Service;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(opt => opt.AddPolicy("Policy", policy =>
{
    policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();

}));
builder.Services.AddScoped<IRoleRepository,RoleRepository>();
builder.Services.AddScoped<IRoleService,RoleService>();
builder.Services.AddScoped<IEmployeeRepository,EmployeeRepository>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();

builder.Services.AddDbContext<DataContext>();

builder.Services.AddAutoMapper(typeof(MappingProfile),typeof(MappingProfilePost));
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("Policy");

app.MapControllers();

app.Run();
