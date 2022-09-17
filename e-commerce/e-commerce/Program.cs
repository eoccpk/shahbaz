using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using e_commerce.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<e_commerceContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("e_commerceContext") ?? throw new InvalidOperationException("Connection string 'e_commerceContext' not found.")));

var app = builder.Build();
//development- dev server
//stagging- stage server
//production- live server
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
