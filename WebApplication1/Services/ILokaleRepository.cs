using WebApplication1.Models;

namespace OnlinebookingSystem.Services
{
	public interface ILokaleRepository 
	{
		List<Lokale> GetAll();
	}
}
