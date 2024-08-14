using Microsoft.AspNetCore.Mvc;
using CoreEKitap.Models;

namespace CoreEKitap.ViewComponents
{
    public class NewBooks: ViewComponent
    {
       public IViewComponentResult Invoke()
        {
            var booksList = new List<CoreEKitap.Models.Kitaplar>
            {
               new Kitaplar
               {
                   ID = 6,
                   KitapAd = "Endişe",
                   Yazar = "Other"
               },
               new Kitaplar
               {
                   ID = 7,
                   KitapAd = "Endişelenme",
                   Yazar = "Other"
               }
        
            };
            // Invoke bu oluşturulan listeyi view'e döndürdü.
            return View(booksList);
        }
    }
}

//Invoke() = ViewComponent'in sonucunu temsil eden ve kullanıcıya döndürülmek üzere işlenmiş 
//bir HTML, JSON veya başka bir içerik türü olabilir.
// Ctrl + Space tuşları kullanılacak keyleri veriyor.
