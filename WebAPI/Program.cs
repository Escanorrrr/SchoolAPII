
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/", () => "Hello World!");
//dotnet new nugetconfig SDK  bulunamıyor diyorsa bunu yapıştır

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();


//app.Run();
