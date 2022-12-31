using System.Text.Json.Serialization;
using c_sharp_entity_framework;
using c_sharp_entity_framework.Utilities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// FIX EAGER
builder.Services.AddControllers().AddJsonOptions(opt =>
    opt.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Scopes 
builder.Services.AddScoped<IUserService, UserServiceFake>();
builder.Services.AddScoped<IChangeTrackerEventHandler, ChangeTrackerEventHandler>();

builder.Services.AddAutoMapper(typeof(Program));


// Connect db
builder.Services.AddDbContext<ApllicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"))
);

var app = builder.Build();

//using (var scope = app.Services.CreateScope())
//{
//    var applicationDbContext = scope.ServiceProvider
//        .GetRequiredService<ApllicationDbContext>();

//    applicationDbContext.Database.Migrate();
//}

// Configure the HTTP request pipeline.

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();

