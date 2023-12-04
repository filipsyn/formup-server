using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1",
        new OpenApiInfo
        {
            Title = "FormUp", Version = "v1",
            Description =
                "Server-side application to store information about workouts, gyms and fit lifestyle in general.",
            Contact = new OpenApiContact
            {
                Url = new Uri("https://github.com/filipsyn/formup-server")
            }
        });
});

builder.Services.AddControllers();

var app = builder.Build();

app.UseSwagger();

app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});

app.UseHttpsRedirection();

app.MapControllers();

app.Run();