using Microsoft.AspNetCore.Mvc;
using CoreEKitap.Models;

namespace CoreEKitap.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            var books = new List<Kitaplar>()
            {
                new Kitaplar(){ID=1,KitapAd="Santraç",Yazar="Aslı"},
                new Kitaplar(){ID=2,KitapAd="Santraç12",Yazar="Miray"},
                new Kitaplar(){ID=3,KitapAd="Santraç14",Yazar="Engin"},
                new Kitaplar(){ID=4,KitapAd="Santraç16",Yazar="Erhan"},
                new Kitaplar(){ID=5,KitapAd="Santraç18",Yazar="Other"}
            };
            return View(books);
        }
    }
}
