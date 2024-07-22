using Microsoft.AspNetCore.Mvc;

namespace TravelTripProje.ViewComponents
{
    public class YorumYap:ViewComponent
    {
        public IViewComponentResult Invoke(int id) 
        {
            TempData["deger"] = id;
            return View();
        }
    }
}
