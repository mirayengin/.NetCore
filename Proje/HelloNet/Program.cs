using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// MVC'yi ve View'leri yapılandır
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Yönlendirme ve uç nokta yapılandırmasını ayarla
app.UseRouting();

// Bu UseEndpoints ile controller yönlendirmesi yapıyoruz ilk açıldığında burda index view açılacak
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}");
});

app.Run();

