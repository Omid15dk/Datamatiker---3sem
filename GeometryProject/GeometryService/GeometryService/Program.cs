using GeometryData.DatabaseLayer;
using GeometryService.BusinessLogicLayer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddTransient<IShapeLogic, LogicControl>();
builder.Services.AddTransient<IShapeAccess, DbShapeAccess>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();