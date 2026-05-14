using System;
using System.Collections.Generic;
using System.Text;

namespace ShelterudlejningssystemetLib
{
    public class BlogListe
    {
        // instans felter
        private List<Blog_opslag> begivenheder;

        // konstruktør
        public BlogListe()
        {
            begivenheder = new List<Blog_opslag>();
        }

        public BlogListe(List<Blog_opslag> begivenheder)
        {
            this.begivenheder = begivenheder;
        }

        public List<Blog_opslag> Begivenheder
        {
            get { return begivenheder; }
            set { begivenheder = value; }
        }

        // tilføj alle metoder under her
        // Tilføjer en Blog opslag til listen
        public void TilføjBlog_opslag(Blog_opslag Blog_opslag)
        {
            begivenheder.Add(Blog_opslag);
        }

        // Sletter en Blog oplsag fra listen 

        public void SletBlog_opslag(int id)
        {
            begivenheder.RemoveAll(b => b.Id == id);
        }
        public List<Blog_opslag> HentAlleBlog()
        {
            return begivenheder;
        }

        // Kalder en liste over Blog opslag der endnu ikke er startet
        public List<Blog_opslag> HentKommendeBlog()
        {
            List<Blog_opslag> kommendeBlog = new List<Blog_opslag>();
            foreach (Blog_opslag b in begivenheder)
            {
                if (b.Dato > DateTime.Now)
                {
                    kommendeBlog.Add(b);
                }
            }

            return kommendeBlog;
        }

        // Redigere en eksisterende opslag med nye værdier 
        public void RedigerBlog_opslag(int nyid, string nytitel, string nytekst, DateTime nydato, string nyimagePath)
        {
            foreach (Blog_opslag b in begivenheder)
            {
                if (b.Id == nyid)
                {
                    b.Titel = nytitel;
                    b.Tekst = nytekst;
                    b.Dato = nydato;
                    b.ImagePath = nyimagePath;
                }
            }
        }

    }
}
