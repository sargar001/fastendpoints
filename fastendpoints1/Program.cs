using FastEndpoints;
using webApplication.DbContext;
using webApplication.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddFastEndpoints();
builder.Services.AddTransient<UserService>();
builder.Services.AddSingleton<Data>();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseFastEndpoints();

app.MapGet("/", () => "Hello World!");

app.Run();
