using System.Diagnostics.Eventing.Reader;
using Microsoft.AspNetCore.Mvc;
//! Buraya model i import ediyoruz.
using HelloNet.Models;


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
        public IActionResult Index5()
        {
            //! Burada models de oluşturulan class içindeki değişkenlere değer atamak için burda bir list oluşturduk.
            //! Bu class ı kullanmak için ise önce bu dayfada import etmemiz lazım.
            var books = new List<Kitap>()
            {
                //! Burada models tarafında değerini atamak için bir list oluşturuyoruz.
                //? Bir obje oluştururken new 'i kullanıyoruz. 
                new Kitap(){ID=1,KitapAd="Zar",Yazar="Asli"},
                new Kitap(){ID=3,KitapAd="Balikcı",Yazar="Miray"},
                new Kitap(){ID=2,KitapAd="Bir Noel",Yazar="Engin"}
            };

            //? Burada Model'e göre oluşturulan list i biz bu public içindeki view e gönderiyoruz.
            return View(books);
        }
    }
}
