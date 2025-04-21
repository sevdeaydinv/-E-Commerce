using Microsoft.AspNetCore.Mvc;
using KodlamaDunyasi.Data;

namespace KodlamaDunyasi.Controllers
{
    public class UrunController : Controller
    {
        private readonly KodlamaDunyasiContext _context;

        public UrunController(KodlamaDunyasiContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var urunler = _context.Urunler.ToList(); // Şimdilik sadece test
            return View(urunler);
        }
    }
}