using System;
using System.Collections.Generic;
using System.Text;

namespace ShelterudlejningssystemetLib
{
    public class Blog_opslag
    {
        // instans felter

        private int _InlægID;
        private string _Titel;
        private string _Tekst;
        private DateTime _Dato;

        // konstruktører

        public Blog_opslag()

        {
            _InlægID = 0;
            _Titel = "";
            _Tekst = "";
            _Dato = DateTime.Now;

        }

        public Blog_opslag(int InlægID, string Titel, string Tekst, DateTime Dato)
        {
            _InlægID = InlægID;
            _Titel = Titel;
            _Tekst = Tekst;
            _Dato = Dato;

        }

        // propeerties
        public int InlægID
        {
            get { return _InlægID; }
            set { _InlægID = value; }
        }
        public string Titel
        {
            get { return _Titel; }
            set { _Titel = value; }
        }
        public string Tekst
        {
            get { return _Tekst; }
            set { _Tekst = value; }
        }
        public DateTime Dato
        {
            get { return _Dato; }
            set { _Dato = value; }
        }


        // metoder 
        public override string ToString()
        {
            return "InlægID: InlægID= " + InlægID + ", Titel= " + Titel + ", Tekst= " + Tekst +
                ", Dato= " + Dato;
        }


    }
}


    
        

