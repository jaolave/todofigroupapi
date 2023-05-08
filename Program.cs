using Microsoft.EntityFrameworkCore;
using ToDoFiGroupApi.Data;
using ToDoFiGroupApi.Interfaces;
using ToDoFiGroupApi.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
//builder.Services.AddDbContext<ToDoDbContext>(options => options.UseSqlite(connectionString));
builder.Services.AddDbContext<ToDoDbContext>(options =>options.UseSqlServer(connectionString));

builder.Services.AddScoped<IToDoRepository, ToDoItemsRepository>();

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
