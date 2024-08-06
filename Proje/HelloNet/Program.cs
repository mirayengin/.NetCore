using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// MVC'yi ve View'leri yapýlandýr
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Yönlendirme ve uç nokta yapýlandýrmasýný ayarla
app.UseRouting();

// Bu UseEndpoints ile controller yönlendirmesi yapýyoruz ilk açýldýðýnda burda index view açýlacak
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}");
});

app.Run();

