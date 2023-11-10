using Mango.ProductAPI.Persistence.ExtensionsDI;
using Mango.ProductAPI.DataComponents.ExtensionsDI;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var path = Directory.GetCurrentDirectory() + "\\" + "appsettings.json";
builder.Services.AddPersistence(path);
builder.Services.AddDataComponents();

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
