using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ShelterRazor.Pages.Log2
{
    public class IndexModel : PageModel
    {
        private LogService _service;

        public List<Log> Logs { get; set; }
        public void OnGet()
        {
        }
    }
}
