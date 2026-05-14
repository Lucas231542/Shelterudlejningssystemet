using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShelterudlejningssystemetLib;
using System.Timers;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ShelterRazor.Pages.Spejderkredse
{
    public class Create_SpejderKredseModel : PageModel
    {
        private ISpejderKredsService _oplysninger;

        public Create_SpejderKredseModel(ISpejderKredsService oplysninger)
        {
            _oplysninger = oplysninger;
        }

        public ISpejderKredsService Oplysninger
        {
            get { return _oplysninger; }
            set { _oplysninger = value; }
        }



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
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name kan ikke være null eller tom.");
                }
                _name = value;
            }
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

        public void OnGet()
        {

        }

       


        public IActionResult OnPostOk()
        {
            SpejderKreds spejderKreds = new SpejderKreds(KredsId, Name, Medlemmer);
            _oplysninger.AddKreds(spejderKreds);
            return RedirectToPage("/Spejderkredse/Index_SpejderKredse");
        }
        public IActionResult OnPostCancel()
        {
            return RedirectToPage("/Spejderkredse/Index_SpejderKredse");
        }
    }
}
