using TImeSheetsSample.Infrastructure.Extensions;

var builder = WebApplication.CreateBuilder(args);


builder.Services.ConfigureDbContext(builder.Configuration);
builder.Services.ConfigureAuthentication(builder.Configuration);
builder.Services.AddAuthorization();
builder.Services.ConfigureRepositories();
builder.Services.ConfigureDomainServices();
builder.Services.ConfigureBackendSwagger();
builder.Services.ConfigureValidation();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers(); 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Timesheets v1"));
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();