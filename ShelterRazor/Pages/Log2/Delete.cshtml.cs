using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShelterudlejningssystemetLib;
namespace ShelterRazor.Pages.Log2
{
    public class DeleteModel : PageModel
    {
        private LogService _service; 
        public Log Log { get; set; }
        public DeleteModel()
        {
            _service = new LogService();
        }
        public void OnGet(int id)
        {
            Log = _service.GetById(id);
        }
        public IActionResult OnPost(int id)
        {
            _service.DeleteLog(id);
            return RedirectToPage("Index");
        }

    }
}
