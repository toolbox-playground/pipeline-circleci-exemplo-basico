// Program.cs
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container (if needed).
        // For this simple example, no additional services are required.

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        app.UseRouting();

        app.MapGet("/", () => "Hello, World!");

        app.Run();
    }
}
