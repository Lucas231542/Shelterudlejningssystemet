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

        // KredsLeder tilføje en begivenhed til kredsens blog
        public void AddEvent(Blog_opslag NewEvent)
        {
            _begivenheder.Add(NewEvent);
        }

        // KredsLeder slette en begivenhed fra kredsens blog
        public void RemoveEvent(int EventToRemove)
        {
            Blog_opslag begivenhed = GetEvent(EventToRemove);
            if (begivenhed != null)
            {
                _begivenheder.Remove(begivenhed);
            }

        }
        // KredsLeder hente alle begivenheder fra kredsens blog
        public List<Blog_opslag> ListAll()
        {
            return new List<Blog_opslag>(_begivenheder);
        }

        // KredsLeder hente en begivenhed fra kredsens blog
        public Blog_opslag GetEvent(int BlogId)
        {
            Blog_opslag resBegivenhed = null; // Return null if not found
            foreach (Blog_opslag b in _begivenheder)
            {
                if (b.Id == BlogId)
                {
                    return b; // Return the found event
                }
            }
            return resBegivenhed;
        }

        // opdatere en begivenhed i kredsens blog
        public Blog_opslag UpdateBegivenhed(int BlogId, Blog_opslag updatedBegivenhed)
        {
            Blog_opslag begivenhed = GetEvent(BlogId);
            if (begivenhed != null)
            {
                begivenhed.Id = updatedBegivenhed.Id;
                begivenhed.Titel = updatedBegivenhed.Titel;
                begivenhed.Tekst = updatedBegivenhed.Tekst;
                begivenhed.Dato = updatedBegivenhed.Dato;
            }
            return begivenhed;
        }
    }
}
