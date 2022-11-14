using Wfl.Api;
using Wfl.Application;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddApplicationLayer();
builder.AddApi();

var app = builder.Build();
app.UseHttpsRedirection();
app.UseApi();
app.Run();