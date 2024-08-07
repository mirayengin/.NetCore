using Microsoft.AspNetCore.Mvc;

namespace HelloNet.Controllers
{
    public class HomeController : Controller
    {

        // IActionResult bir tetikleme için kullanılıyor ve index adında bir metod çalıştırdığında bir view sana döndürecem.
        public IActionResult Index()
        {
            return View();
        }

        //! Bunlar ile view leri oluşturup onları run yaptırıyoruz.
        public IActionResult Index2()
        {
            return View();
        }

        //? Burada sayfada ne olacaksa onu yazıyoruz yani ne return edeceksek. 
        //?Burda int bir değer döndürecez o sebeple int dedik.
        public int Index3()
        {
            return 32;
        }

        public string Index4()
        {
            return "Bugün burda tembellik yapasım geldi";
        }
    }
}
