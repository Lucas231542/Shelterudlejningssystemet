using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShelterudlejningssystemetLib;

namespace ShelterRazor.Pages.FdfShelter
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public FDF_Shelter Shelter {  get; set; }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            IndexModel.Shelters.Add(Shelter);
            return RedirectToPage ("Index");

        }
    }
}
