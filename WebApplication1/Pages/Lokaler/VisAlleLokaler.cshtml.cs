using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlinebookingSystem.Services;
using WebApplication1.Models;

namespace OnlinebookingSystem.Pages.Lokaler
{
	public class VisAlleLokalerModel : PageModel
	{

		private ILokaleRepository _lokaleRepository;
		public List<Lokale> Lokaler { get; set; }
		public void OnGet()
		{
			Lokaler = _lokaleRepository.GetAll();
		}

		public VisAlleLokalerModel(ILokaleRepository lokaleRepository)
		{
			_lokaleRepository = lokaleRepository;
		}
	
	}
    
}
