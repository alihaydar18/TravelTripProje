using Microsoft.AspNetCore.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class DefaultController : Controller
    {
        private readonly ApplicationDbContext _context;
        public DefaultController(ApplicationDbContext context) 
        {
            _context = context; 
        }
        public IActionResult Index()
        {
            var degerler = _context.Blogs.ToList();
            return View(degerler);
        }
        public ActionResult About() 
        {
            return View();
        }
        public PartialViewResult Partial1() 
        {
            var degerler = _context.Blogs.Take(2).ToList();
            return PartialView(degerler);        
        }
        public PartialViewResult Partial2() 
        {
            var degerler = _context.Blogs.ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial3() 
        {
            var degerler = _context.Blogs.Take(3).ToList();
            return PartialView(degerler);
        }
    }
}
