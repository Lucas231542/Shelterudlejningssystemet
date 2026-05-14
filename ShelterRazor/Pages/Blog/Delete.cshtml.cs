using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShelterudlejningssystemetLib;

namespace ShelterRazor.Pages.Blog
{
    public class DeleteModel : PageModel
    {
        private readonly BlogListe _service;

        public DeleteModel(BlogListe service)
        {
            _service = service;
        }

        [BindProperty]
        public int Id { get; set; } 
        public void OnGet(int id)
        {
            Id = id;
        }

        public IActionResult OnPostSlet()
        {
            _service.SletBlog_opslag(Id);
            return RedirectToPage("/Blog/Index");
        }
    }
}
