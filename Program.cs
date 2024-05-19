using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Fit_IT_API.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Fit_IT_APIContext>(options =>
    options.UseInMemoryDatabase(builder.Configuration.GetConnectionString("Fit_IT_APIContext") ?? throw new InvalidOperationException("Connection string 'Fit_IT_APIContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.Converters.Add(new System.Text.Json.Serialization.JsonStringEnumConverter());
});
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

app.UseAuthorization();

app.MapControllers();

app.Run();
