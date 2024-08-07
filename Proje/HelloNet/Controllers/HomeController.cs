﻿using Microsoft.AspNetCore.Mvc;

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
    }
}
