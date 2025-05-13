using WebApplication1.Models;

namespace OnlinebookingSystem.Services
{
	public class LokaleRepository
	{
		public List<Lokale> GetAll()
		{
			using BookingContext context = new BookingContext();
			return context.Lokales.ToList();
		}
	}
}
