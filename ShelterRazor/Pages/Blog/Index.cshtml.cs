using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShelterudlejningssystemetLib;

namespace ShelterRazor.Pages.Blog
{
    public class IndexModel : PageModel
    {
        private Blog_opslag _Opslag;

        public IndexModel(Blog_opslag opslag)
        {
            _Opslag = opslag;
        }

        // property
        public Blog_opslag Opslag
        {
            get { return _Opslag; }
            set { _Opslag = value; }
        }

        public void OnGet()
        {
        }
    }
}
