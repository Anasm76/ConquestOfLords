using ConquestOfLords.Components;
using ConquestOfLords.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        sqlOptions => sqlOptions.EnableRetryOnFailure()
    ));

var app = builder.Build();

// Add routing before other middleware
app.UseRouting();

app.UseStaticFiles();
app.UseAntiforgery();

// Add endpoint mapping
app.UseEndpoints(endpoints =>
{
    endpoints.MapRazorComponents<App>()
        .AddInteractiveServerRenderMode();
});


app.Run();