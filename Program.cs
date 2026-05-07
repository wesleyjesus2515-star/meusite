using minhaloja.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddRazorPages();

builder.Services.AddDbContext<AppBdContext>(options =>options.UseSqlite("Data Source=produtos.db"));

builder.Services.AddScoped<minhalojaRepository>();
var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
var db = scope.ServiceProvider.GetRequiredService<AppBdContext>();
db.Database.EnsureCreated();
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();


app.MapRazorPages();
  

app.Run();
