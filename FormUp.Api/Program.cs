using FormUp.Api.Common.Middleware;
using FormUp.Api.Data;
using FormUp.Api.Features.v1.Exercises;
using FormUp.Api.Features.v1.Gyms;
using FormUp.Api.Features.v1.Translations;
using FormUp.Api.Features.v1.Users;
using FormUp.Api.Features.v1.Workouts;

using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Database") ??
                         throw new InvalidOperationException("Connection string to database was not found"));
});

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1",
        new OpenApiInfo
        {
            Title = "FormUp",
            Version = "v1",
            Description =
                "Server-side application to store information about workouts, gyms and fit lifestyle in general.",
            Contact = new OpenApiContact { Url = new Uri("https://github.com/filipsyn/formup-server") }
        });
});

builder.Services.AddScoped<IGymsService, GymsService>();
builder.Services.AddScoped<IExercisesService, ExercisesService>();
builder.Services.AddScoped<IWorkoutsService, WorkoutsService>();
builder.Services.AddScoped<ITranslationService, TranslationService>();
builder.Services.AddScoped<IUsersService, UsersService>();

builder.Services.AddControllers();

builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
builder.Services.AddProblemDetails();

builder.Host.UseSerilog((context, configuration) =>
{
    configuration.ReadFrom.Configuration(context.Configuration);
    configuration.WriteTo.Console();
});

var app = builder.Build();

app.UseSerilogRequestLogging();

app.UseSwagger();

app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});

app.UseHttpsRedirection();

app.MapControllers();

app.UseExceptionHandler();

app.Run();