using ComandaZap.Configuration;
using ComandaZap.Data;
using ComandaZap.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddDbContext<ApplicationContext>(e =>
{
    e.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services
    .AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationContext>()
    .AddDefaultTokenProviders();

builder.Services.Configure<IdentityOptions>(o =>
{
    o.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromSeconds(60);
    o.Lockout.MaxFailedAccessAttempts = 5;
    //o.SignIn.RequireConfirmedAccount = true;
});

builder.Services.AddAuthentication()
    .AddGoogle(o =>
    {
        o.ClientId = builder.Configuration.GetSection("GClientId").Value ?? throw new ArgumentNullException(nameof(o.ClientId));
        o.ClientSecret = builder.Configuration.GetSection("GClientSecret").Value ?? throw new ArgumentNullException(nameof(o.ClientSecret));
        o.AuthorizationEndpoint += "?prompt=consent";
    });

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseAuthentication();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
