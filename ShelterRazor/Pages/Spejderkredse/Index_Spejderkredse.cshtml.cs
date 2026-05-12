using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShelterudlejningssystemetLib;

namespace ShelterRazor.Pages.Spejderkredse
{
    public class Index_SpejderkredseModel : PageModel
    {
        private ISpejderKredsService _spejderKredsService;

        public Index_SpejderkredseModel(ISpejderKredsService spejderKredsService)
        {
            _spejderKredsService = spejderKredsService;
        }

        // Property
        public ISpejderKredsService SpejderKredsService
        {
            get { return _spejderKredsService; }
            set { _spejderKredsService = value; }
        }
        public void OnGet()
        {
        }
    }
}
