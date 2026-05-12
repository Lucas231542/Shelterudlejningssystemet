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
            Dato = DateTime.Now;        // Dette gør at startdatoen som kan vælges er den nuværende dato, så man ikke starter fra år 1
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
        private string _imagePath;

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
        [BindProperty]
        public string ImagePath
        {
            get { return _imagePath; }
            set { _imagePath = value; }
        }
        public void OnGet()
        {
        }

        public IActionResult OnPostOk()
        {
            Blog_opslag blog_opslag = new Blog_opslag(Id, Titel, Tekst, Dato, ImagePath);
            _Opslag.TilføjBlog_opslag(blog_opslag);
            return RedirectToPage("/Blog/Index");
        }
        public IActionResult OnPostCancel()
        {
            return RedirectToPage("/Blog/Index");
        }
    }
}
