using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// MVC'yi ve View'leri yap�land�r
builder.Services.AddControllersWithViews();

var app = builder.Build();

//! Bu method ise wwwroot dosyasında bulunan statik dosyalardaki verileri kullanmamızı sağlıyor.
app.UseStaticFiles();
// Y�nlendirme ve u� nokta yap�land�rmas�n� ayarla
app.UseRouting();

// Bu UseEndpoints ile controller y�nlendirmesi yap�yoruz ilk a��ld���nda burda index view a��lacak
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}");
});

app.Run();

