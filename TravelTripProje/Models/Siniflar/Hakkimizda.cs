using System.ComponentModel.DataAnnotations;

namespace TravelTripProje.Models.Siniflar
{
	public class Hakkimizda
	{
		[Key]
        public int ID { get; set; }
		public string Fotourl { get; set; }
		public string Aciklama { get; set;}
    }
}
