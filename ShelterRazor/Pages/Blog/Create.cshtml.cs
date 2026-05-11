using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShelterudlejningssystemetLib;

namespace ShelterRazor.Pages.Blog
{
    public class CreateModel : PageModel
    {
        private BlogListe _Opslag;

        public CreateModel(BlogListe opslag)
        {
            _Opslag = opslag;
        }

        public BlogListe Opslag
        {
            get { return _Opslag; }
            set { _Opslag = value; }
        }


        // til det nye blog opslag
        private int _id;
        private string _titel;
        private string _tekst;
        private DateTime _dato;

        [BindProperty]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [BindProperty]
        public string Titel
        {
            get { return _titel; }
            set { _titel = value; }
        }
        [BindProperty]
        public string Tekst
        {
            get { return _tekst; }
            set { _tekst = value; }
        }
        [BindProperty]
        public DateTime Dato
        {
            get { return _dato; }
            set { _dato = value; }
        }
        public void OnGet()
        {
        }

        public IActionResult OnPostOk()
        {
            Blog_opslag blog_opslag = new Blog_opslag(Id, Titel, Tekst, Dato);
            _Opslag.TilføjBlog_opslag(blog_opslag);
            return RedirectToPage("/Blog/Index");
        }
        public IActionResult OnPostCancel()
        {
            return RedirectToPage("/Blog/Index");
        }
    }
}
