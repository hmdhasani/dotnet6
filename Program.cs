using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var counter = 0;

app.MapGet("/", () => {
   return $"Hello, World {counter++}!!"; 
});

app.MapGet("/run", (ulong num) => {
   var random = new Random();

   var stopWatch = new System.Diagnostics.Stopwatch();
   stopWatch.Start();

   for (ulong i = 0; i < num; i++)
   {
      var n1 = random.Next(1_000_000);
      var n2 = random.Next(1_000_000);
      var n3 = n1*n2;
   }

   stopWatch.Stop();

   return $"done, after {stopWatch.Elapsed}"; 
});

app.Run();