using Microsoft.EntityFrameworkCore;
using WebShopSana.BL.ProductsBL;
using WebShopSana.DAL.Context;
using WebShopSana.DAL.Generic;
using WebShopSana.DAL.Interfaces;
using WebShopSana.DAL.ProductDAL;
using WebShopSana.MODELS.Entities;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IUnitOfWork<Products>, UnitOfWork<Products>>();
builder.Services.AddTransient<IProductsServiceBL, ProductsServiceBL>();
builder.Services.AddTransient<IProductsDAL, ProductsDAL>();

builder.Services.AddDbContext<ApplicationContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ApplicationContext")));


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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
