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
    }
}
