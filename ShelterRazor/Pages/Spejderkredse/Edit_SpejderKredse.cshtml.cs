using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShelterudlejningssystemetLib;

namespace ShelterRazor.Pages.Spejderkredse
{
    public class Edit_SpejderKredseModel : PageModel
    {
        private readonly ISpejderKredsService _service;
        private int _kredsId;
        private string _name;
        private int _medlemmer;

        [BindProperty]
        public int KredsId
        {
            get { return _kredsId; }
            set { _kredsId = value; }
        }
        [BindProperty]
        public string Name
        {
            get { return _name; }
            set
            { _name = value; }
        }
        [BindProperty]
        public int Medlemmer
        {
            get { return _medlemmer; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Antal kan ikke være negativt.");
                }
                _medlemmer = value;
            }
        }
        public Edit_SpejderKredseModel(ISpejderKredsService service)
        {
            _service = service;
        }

        public void OnGet(int kredsId)
        {
            foreach (var k in _service.GetAll())
            {
                if (k.KredsId == kredsId)
                {
                    KredsId = k.KredsId;
                    Name = k.Name;
                    Medlemmer = k.Medlemmer;
                }
            }
        }

        public IActionResult OnPostOk()
        {
            _service.Edit(KredsId, Name, Medlemmer);
            return RedirectToPage("/Spejderkredse/Index_SpejderKredse");
        }

        public IActionResult OnPostAnnuller()
        {
            return RedirectToPage("/Spejderkredse/Index_SpejderKredse");
        }
    }
}
