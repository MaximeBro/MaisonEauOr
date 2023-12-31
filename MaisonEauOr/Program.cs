using MaisonEauOr.Databases;
using MaisonEauOr.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddMudServices();
builder.Services.AddScoped<ProtectedSessionStorage>();
builder.Services.AddScoped<AuthenticationStateProvider, AuthenticationService>();
builder.Services.AddAuthenticationCore();
builder.Services.AddDbContextFactory<MeoDbContext>(optionsAction =>
{
    optionsAction.UseSqlite("Data Source=../meo-data/meo.db");
});
builder.Services.AddHttpContextAccessor();
builder.Services.AddSingleton<DoubleAuthService>();
builder.Services.AddSingleton<MailerService>();
builder.Services.AddSingleton<BasketService>();
builder.Services.AddSingleton<LocalizationService>();

var app = builder.Build();

if (!Directory.Exists("../meo-data")) Directory.CreateDirectory("../meo-data");
if (!Directory.Exists("./wwwroot/images/upload")) Directory.CreateDirectory("./wwwroot/images/upload");

using (var serviceScope = app.Services.CreateScope())
{
    var dbContext = serviceScope.ServiceProvider.GetRequiredService<MeoDbContext>();
    dbContext.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHttpsRedirection();
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();