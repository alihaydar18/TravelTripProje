using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TravelTripProje.Models;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{

	public class BlogController : Controller
	{
		private readonly ApplicationDbContext _context;
		public BlogController(ApplicationDbContext context) 
		{
			_context = context; 
		}
        
		BlogYorum by = new BlogYorum();
        public IActionResult Index()
		{
			//var degerler = _context.Blogs.ToList();
			by.Deger1 = _context.Blogs.ToList();
			by.Deger3 = _context.Blogs.OrderByDescending(x=>x.ID).Take(3).ToList();
			return View(by);
		}

		
		public IActionResult BlogDetay(int id) 
		{
            ViewBag.deger = id;
            //var blogbul = _context.Blogs.Where(x=> x.ID == id).ToList();
            by.Deger1 = _context.Blogs.Where(x=>x.ID == id).ToList();
			by.Deger2 = _context.Yorumlars.Where(x=>x.BlogID == id).ToList();
			return View(by);
		}



        [HttpPost]
		public IActionResult YorumEkle(YorumModel model) 
		{
			_context.Yorumlars.Add(new Yorumlar() { BlogID=model.BlogID,KullaniciAdi=model.KullaniciAdi,Mail=model.Mail,Yorum=model.Yorum});
			_context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
