using Microsoft.AspNetCore.Mvc;
using UrunEklemeUygulaması.Models;

namespace UrunEklemeUygulaması.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Product model)
        {
            ModelState.Clear();
            if (ModelState.IsValid)
            {
                // Veri geçerli, burada veritabanına eklenebilir.
                ViewBag.Message = "Ürün başarıyla eklendi.";
                return View();
            }

            return View(model);
        }
    }
}
