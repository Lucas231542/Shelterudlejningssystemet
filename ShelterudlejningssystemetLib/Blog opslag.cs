using System;
using System.Collections.Generic;
using System.Text;

namespace ShelterudlejningssystemetLib
{
    public class Blog_opslag
    {
        // instans felter

        private int _id;
        private string _titel;
        private string _tekst;
        private DateTime _dato;

        // konstruktører

        public Blog_opslag()

        {
            _id = 0;
            _titel = "";
            _tekst = "";
            _dato = DateTime.Now;

        }

        public Blog_opslag(int id, string titel, string tekst, DateTime dato)
        {
            _id = id;
            _titel = titel;
            _tekst = tekst;
            _dato = dato;

        }

        // liste over alle Blog opslag

        private static List<Blog_opslag> _alleBlog_opslag = new List<Blog_opslag>();


        // propeerties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Titel
        {
            get { return _titel; }
            set { _titel = value; }
        }
        public string Tekst
        {
            get { return _tekst; }
            set { _tekst = value; }
        }
        public DateTime Dato
        {
            get { return _dato; }
            set { _dato = value; }
        }

        // Tilføjer en Blog opslag til listen
        public static void TilføjBlog_opslag(Blog_opslag Blog_opslag)
        {
        _alleBlog_opslag.Add(Blog_opslag);
        }

        // Sletter en Blog oplsag fra listen 

        public static void SletBlog_opslag(int id)
        {
            _alleBlog_opslag.RemoveAll(b => b._id == id);
        }

        // Kalder en liste over Blog opslag der endnu ikke er startet
        public static List<Blog_opslag> HentKommendeBlog()
        {
            List<Blog_opslag> kommendeBlog = new List<Blog_opslag>();
            foreach (Blog_opslag b in _alleBlog_opslag)
            {
                if (b.Dato > DateTime.Now)
                {
                    kommendeBlog.Add(b);
                }
            }

            return kommendeBlog;
        }

        // Redigere en eksisterende opslag med nye værdier 
        public static void RedigerBlog_opslag(int nyid, string nytitel, string nytekst, DateTime nydato)
        {
            foreach (Blog_opslag b in _alleBlog_opslag)
            {
                if (b._id == nyid)
                {
                    b._titel = nytitel;
                    b._tekst = nytekst;
                    b._dato = nydato;
                }
            }
        }


        // metoder 
        public override string ToString()
        {
            return "InlægID: InlægID= " + Id + ", Titel= " + Titel + ", Tekst= " + Tekst +
                ", Dato= " + Dato;
        }


    }
}


    
        

