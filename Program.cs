using Microsoft.EntityFrameworkCore;
using TImeSheetsSample.Data_Layer;
using TImeSheetsSample.Data_Layer.Implementation;
using TImeSheetsSample.Data_Layer.Interfaces;
using TImeSheetsSample.Data.Interfaces;
using TImeSheetsSample.Services.Implementation;
using TImeSheetsSample.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<TimeSheetDbContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ISheetRepo, SheetRepo>();
builder.Services.AddScoped<ISheetService, SheetService>();
builder.Services.AddScoped<IContractRepo, ContractRepo>();
builder.Services.AddScoped<IContractService, ContractService>();

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