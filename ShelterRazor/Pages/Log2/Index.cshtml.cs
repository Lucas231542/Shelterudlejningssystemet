using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShelterudlejningssystemetLib;
namespace ShelterRazor.Pages.Log2
{
    public class IndexModel : PageModel
    {
        private LogService _service;

        public List<Log> Logs { get; set; }
        public IndexModel()
        {
            _service = new LogService();

        
        }
        public void OnGet()
        {
            Logs = _service.GetAll();
        }
    }
}
