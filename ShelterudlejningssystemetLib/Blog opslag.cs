using System;
using System.Collections.Generic;
using System.Text;

// Blog oplsag Ahmad 

namespace ShelterudlejningssystemetLib
{
    public class Blog_opslag
    {
        // instans felter

        private int _id;
        private string _titel;
        private string _tekst;
        private DateTime _dato;
        private string _imagePath;

        // konstruktører

        public Blog_opslag()

        {
            _id = 0;
            _titel = "";
            _tekst = "";
            _dato = DateTime.Now;
            _imagePath = "";

        }

        public Blog_opslag(int id, string titel, string tekst, DateTime dato, string imagePath)
        {
            _id = id;
            _titel = titel;
            _tekst = tekst;
            _dato = dato;
            _imagePath = imagePath;

        }

        // liste over alle Blog opslag

        private List<Blog_opslag> begivenheder = new List<Blog_opslag>();


        // properties
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

        public string ImagePath
        {
            get { return _imagePath; }
            set { _imagePath = value; }
        }

       

        // metoder 
        public override string ToString()
        {
            return "InlægID: InlægID= " + Id + ", Titel= " + Titel + ", Tekst= " + Tekst +
                ", Dato= " + Dato + ", Billede= " + ImagePath;
        }


    }
}


    
        

