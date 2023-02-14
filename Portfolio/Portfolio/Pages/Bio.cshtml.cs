using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Portfolio.Pages
{
    public class BioModel : PageModel
    {
        private readonly ILogger<BioModel> _logger;

        public BioModel(ILogger<BioModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}