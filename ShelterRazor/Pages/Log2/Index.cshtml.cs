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


            _service.Addlog(new Log(
                1,
                DateTime.Now,
                DateTime.Now.AddDays(1),
                "Spejdertur",
                101));

            _service.Addlog(new Log(
                2,
                DateTime.Now,
                DateTime.Now.AddDays(2),
                "Blåaften",
                102));
        
        }
        public void OnGet()
        {
            Logs = _service.GetAll();
        }
    }
}
