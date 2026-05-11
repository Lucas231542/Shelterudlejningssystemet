using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShelterudlejningssystemetLib;

namespace ShelterRazor.Pages.Blog
{
    public class IndexModel : PageModel
    {
        private BlogListe _Opslag;

        public IndexModel(BlogListe opslag)
        {
            _Opslag = opslag;
        }

        // property
        public BlogListe Opslag
        {
            get { return _Opslag; }
            set { _Opslag = value; }
        }

        public void OnGet()
        {
        }
    }
}
