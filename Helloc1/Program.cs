using Microsoft.AspNetCore.Http;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async(context) =>
{
    var response = context.Response;
    response.ContentType = "text/html; charset=utf-8";
    await Task.Delay(1000);
    int x = 0;
    while (x <100)
    {
        x++;
        await Task.Delay(1000);
        await context.Response.WriteAsync($"this is number: {x}\n");
    }
    
    
});

app.Run();
