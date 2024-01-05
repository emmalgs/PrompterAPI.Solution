using PrompterApi.Models;
using PrompterApi.Startup;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.RegisterServices();

builder.Services.AddDbContext<PrompterApiContext>(
                  dbContextOptions => dbContextOptions
                    .UseMySql(
                      builder.Configuration["ConnectionStrings:AZURE_SQL_CONNECTION"],
                      ServerVersion.AutoDetect(builder.Configuration["ConnectionStrings:AZURE_SQL_CONNECTION"]
                    )
                  )
                );

var app = builder.Build();

app.ConfigureSwagger();

app.UseStaticFiles();

app.UseRouting();

app.MapControllers();

app.Run();