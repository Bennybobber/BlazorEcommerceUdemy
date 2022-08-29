global using BlazorEcommerceUdemy.Shared;
global using System.Net.Http.Json;
global using BlazorEcommerceUdemy.Client.Services.ProductService;
global using BlazorEcommerceUdemy.Client.Services.CategoryService;
global using BlazorEcommerceUdemy.Client.Services.CartService;
using BlazorEcommerceUdemy.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazored.LocalStorage;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICartService, CartService>();
await builder.Build().RunAsync();
