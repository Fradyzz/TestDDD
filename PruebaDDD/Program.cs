using MediatR;
using Prueba.CQRS;
using Prueba.CQRS.Handlers;
using Prueba.CQRS.Queries;
using Prueba.CQRS.Response;
using Prueba.Infraestructure.Repository;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

//Get ConnectionString
var connectionString = builder.Configuration.GetConnectionString("local");

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddMediatR(typeof(MediatorAssembly).Assembly);
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
//builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(GetAllCabinetHandler<,>));
//builder.Services.AddMediatR(typeof(MediatorAssembly).Assembly);
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>(s => new UnitOfWork(connectionString));

//Endpoints
builder.Services.AddTransient<IRequestHandler<GetAllCabinetQuery, List<GetAllCabinetResponse?>>, GetAllCabinetHandler>();

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
