
using Scalar.AspNetCore;

namespace Time.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddAuthorization();

            builder.Services.AddOpenApi();

            var app = builder.Build();

            app.MapOpenApi();
            app.MapScalarApiReference();
            
            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapGet("/time", async (HttpContext httpContext) =>
            {
                return Results.Ok(DateTime.UtcNow.ToString("O"));
            })
            .WithName("time");

            app.Run();
        }
    }
}
