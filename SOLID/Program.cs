using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SOLID.Models;
using SOLID.Repository.Interface;
using SOLID.Repository.Service.DIP;
using SOLID.Repository.Service.Factory;
using SOLID.Repository.Service.OCP;
using SOLID.Repository.Service.SRP;
using System;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddRazorPages();


#region Add Database Context
builder.Services.AddDbContext<AppDBContext>(x =>
                x.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection"),
                    y => y.UseNetTopologySuite()));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
#endregion

builder.Services.AddTransient<IPaymentProcessor, CreditCardPayment>(); 
builder.Services.AddTransient<IPaymentProcessor, PaypalPayment>();

// Register services (all used in NotificationFactory, as same interface is used for different implementation)
builder.Services.AddTransient<IInstanceFactory<INotification>, NotificationFactory>();
builder.Services.AddScoped<INotification, EmailNotification>();
builder.Services.AddScoped<INotification, SMSNotification>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
