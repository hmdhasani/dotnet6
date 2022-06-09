using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder();
var app = builder.Build();

var counter = 0;

app.MapGet("/", () => {
   return $"Hello, World {counter++}!!"; 
});

app.MapGet("/fact", (int num) => {
   ulong result = 1;

   do
   {
      result *= (ulong)num;
   } while(num-- > 1);

   return result; 
});

app.Run();