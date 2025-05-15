



	public class LokaleRepository : ILokaleRepository
	{
		public List<Lokale> GetAll()
		{
			using BookingContext context = new BookingContext();
			return context.Lokales.ToList();
		}
	}

