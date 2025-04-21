using IletişimFormu.Models;
using Microsoft.AspNetCore.Mvc;

namespace IletişimFormu.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            if (ModelState.IsValid)
            {
                // Form alanlarını temizlemek için:
                ModelState.Clear();
                // Veri doğrulandı, burada işlenebilir (veritabanına ekleme gibi).
                ViewBag.Message = "Mesajınız başarıyla gönderildi.";
                return View();
            }

            // Hatalıysa form tekrar gösterilir.
            return View(contact);
        }
    }
}
