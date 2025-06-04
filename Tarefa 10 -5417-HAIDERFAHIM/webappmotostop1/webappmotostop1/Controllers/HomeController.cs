using Microsoft.AspNetCore.Mvc;
using webappmotostop1.Data;

namespace webappmotostop1.Controllers
{
    public class HomeController : Controller
    {
        private readonly WEBASPITSContext _context;

        public HomeController(WEBASPITSContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewData["TotalClients"] = _context.Clients.Count();
            ViewData["TotalMotos"] = _context.Motos.Count(); // make sure DbSet<Moto> Motos exists
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}