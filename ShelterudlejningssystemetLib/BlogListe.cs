using System;
using System.Collections.Generic;
using System.Text;

namespace ShelterudlejningssystemetLib
{
    public class BlogListe
    {
        // instans felter
        private List<Blog_opslag> _begivenheder;

        // konstruktør
        public BlogListe()
        {
            _begivenheder = new List<Blog_opslag>();
        }

        public BlogListe(List<Blog_opslag> begivenheder)
        {
            _begivenheder = begivenheder;
        }

        public List<Blog_opslag> Begivenheder
        {
            get { return _begivenheder; }
            set { _begivenheder = value; }
        }

        // tilføj alle metoder under her
        // Tilføjer en Blog opslag til listen
        public void TilføjBlog_opslag(Blog_opslag Blog_opslag)
        {
            _begivenheder.Add(Blog_opslag);
        }

        // Sletter en Blog oplsag fra listen 

        public void SletBlog_opslag(int id)
        {
            _begivenheder.RemoveAll(b => b._id == id);
        }

        // Kalder en liste over Blog opslag der endnu ikke er startet
        public List<Blog_opslag> HentKommendeBlog()
        {
            List<Blog_opslag> kommendeBlog = new List<Blog_opslag>();
            foreach (Blog_opslag b in _begivenheder)
            {
                if (b.Dato > DateTime.Now)
                {
                    kommendeBlog.Add(b);
                }
            }

            return kommendeBlog;
        }

        // Redigere en eksisterende opslag med nye værdier 
        public void RedigerBlog_opslag(int nyid, string nytitel, string nytekst, DateTime nydato)
        {
            foreach (Blog_opslag b in begivenheder)
            {
                if (b._id == nyid)
                {
                    b._titel = nytitel;
                    b._tekst = nytekst;
                    b._dato = nydato;
                }
            }
        }

    }
}
