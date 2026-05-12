using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShelterudlejningssystemetLib;

namespace ShelterRazor.Pages.Spejderkredse
{
    public class Index_SpejderkredseModel : PageModel
    {
        private SpejderKredsService _spejderKredsService;

        public Index_SpejderkredseModel(SpejderKredsService spejderKredsService)
        {
            _spejderKredsService = spejderKredsService;
        }

        // Property
        public SpejderKredsService SpejderKredsService
        {
            get { return _spejderKredsService; }
            set { _spejderKredsService = value; }
        }
        public void OnGet()
        {
        }
    }
}
