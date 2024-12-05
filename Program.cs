using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using FilMovie.Data;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Configuration de DbContext pour l'application
        builder.Services.AddDbContext<FilMovieContext>(options =>
            options.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=1234"));

        var app = builder.Build();

        app.Run();
    }
}