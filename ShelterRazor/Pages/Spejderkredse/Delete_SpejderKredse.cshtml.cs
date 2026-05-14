using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShelterudlejningssystemetLib;

namespace ShelterRazor.Pages.Spejderkredse
{
    public class Delete_SpejderKredseModel : PageModel
    {
        private readonly ISpejderKredsService _service;

        public Delete_SpejderKredseModel(ISpejderKredsService service)
        {
            _service = service;
        }

        [BindProperty]
        public int KredsId { get; set; }

        public void OnGet(int kredsId)
        {
            KredsId = kredsId;
        }

        public IActionResult OnPostSlet()
        {
            _service.Remove(KredsId);
            return RedirectToPage("/Spejderkredse/Index_SpejderKredse");

        }
    }
}

