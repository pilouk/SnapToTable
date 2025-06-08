using Scalar.AspNetCore;
using SnapToTable.Application.Features.RecipeAnalysisRequest.CreateRecipeAnalysisRequest;
using SnapToTable.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<CreateRecipeAnalysisRequestCommand>());
builder.Services.AddInfrastructure(configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
