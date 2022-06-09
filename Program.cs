using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder();
var app = builder.Build();

var counter = 0;

app.MapGet("/", () => {
   return $"Hello, Class {counter++}!!"; 
});

app.Run();