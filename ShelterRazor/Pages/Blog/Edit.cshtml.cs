using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShelterudlejningssystemetLib;

namespace ShelterRazor.Pages.Blog
{
    public class EditModel : PageModel
    {
        private readonly BlogListe _service;
        private int id;
        private string _titel;
        private string _tekst;
        private DateTime _dato;
        private string _imagePath;
        private readonly IWebHostEnvironment _env;

        public EditModel(BlogListe service, IWebHostEnvironment env)
        {
            _service = service;
            _env = env;
        }
        public List<string> ImageFiles { get; set; }

        [BindProperty]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        [BindProperty]
        public string Titel
        {
            get { return _titel; }
            set
            { _titel = value; }
        }
        [BindProperty]
        public string Tekst
        {
            get { return _tekst; }
            set
            {
                _tekst = value;
            }
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
     
        public void OnGet(int id)
        {
            foreach (var k in _service.HentAlleBlog())
            {
                if (k.Id == id)
                {
                    Id = k.Id;
                    Titel = k.Titel;
                    Tekst = k.Tekst;
                    Dato = k.Dato;
                    string imagePath = Path.Combine(_env.WebRootPath, "images");
                    ImageFiles = Directory.GetFiles(imagePath).Select(f => "/images/" + Path.GetFileName(f)).ToList();
                }
            }
        }

        public IActionResult OnPostOk()
        {
            _service.RedigerBlog_opslag(Id, Titel, Tekst, Dato, ImagePath);
            return RedirectToPage("/Blog/Index");
        }

        public IActionResult OnPostAnnuller()
        {
            return RedirectToPage("/Blog/Index");
        }
    }
}

    

