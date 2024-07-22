using Microsoft.AspNetCore.Mvc;
using TravelTripProje.Models.Siniflar;
namespace TravelTripProje.Controllers
{
    public class AboutController : Controller
    {
        private readonly ApplicationDbContext _context;
		public AboutController(ApplicationDbContext context)
		{
			_context = context;
		}

		public IActionResult Index()
        {
            var degerler = _context.Hakkimizdas.ToList();
            return View(degerler);
        }
    }
}
