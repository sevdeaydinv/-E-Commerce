using KodlamaDunyasi.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// DbContext tan�m�
builder.Services.AddDbContext<KodlamaDunyasiContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("KodlamaDunyasiBaglantisi")));

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Varsay�lan controller ve action'� Uruns/Index olarak g�ncelledik
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Uruns}/{action=Index}/{id?}");

app.Run();