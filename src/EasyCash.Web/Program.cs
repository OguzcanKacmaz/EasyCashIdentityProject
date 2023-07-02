using EasyCash.DataAccessLayer.Concrete;
using EasyCash.DataAccessLayer.Extensions;
using EasyCash.EntityLayer.Concrete;
using EasyCash.BusinessLayer.Extensions;

using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services
    .AddDbContextConnection(builder.Configuration)    
    .AddBusinessService();

builder.Services.AddIdentity<AppUser, AppRole>()
	.AddSignInManager<SignInManager<AppUser>>()
	.AddEntityFrameworkStores<ApplicationDbContext>()
	.AddDefaultTokenProviders();


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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
