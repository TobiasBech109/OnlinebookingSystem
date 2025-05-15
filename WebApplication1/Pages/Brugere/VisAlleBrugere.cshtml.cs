using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;



    public class VisAlleBrugereModel : PageModel
    {
        private IBrugerRepository _brugerRepository;
        public List<Bruger> Brugere { get; set; } 
        public void OnGet()
        {
            Brugere = _brugerRepository.GetAll();
        }

        public VisAlleBrugereModel(IBrugerRepository brugerRepository)
        {
            _brugerRepository = brugerRepository;
        }
    }
