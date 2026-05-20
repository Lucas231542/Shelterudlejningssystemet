using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShelterudlejningssystemetLib;
using System;

namespace ShelterRazor.Pages.Log2
{
    public class CreateModel : PageModel
    {
        private LogService _service;

        [BindProperty]
        public Log Log { get; set; }

        public CreateModel()
        {
            _service = new LogService(); 
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            _service.Addlog(Log);

            return RedirectToPage("Index");
        }
    }
}
