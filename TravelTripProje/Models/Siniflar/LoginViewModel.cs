using System.ComponentModel.DataAnnotations;

namespace TravelTripProje.Models.Siniflar
{
	public class LoginViewModel
	{
		public string KullaniciAdi { get; set; }
		
		public string Password { get; set; }
		public bool RememberMe { get; set; }
	}
}