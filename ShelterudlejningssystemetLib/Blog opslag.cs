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

        // propeerties
        public int ID
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


        // metoder 
        public override string ToString()
        {
            return "InlægID: InlægID= " + InlægID + ", Titel= " + Titel + ", Tekst= " + Tekst +
                ", Dato= " + Dato;
        }


    }
}


    
        

       
