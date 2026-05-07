using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ShelterudlejningssystemetLib
{
    public class Roller
    {

        // Instansfelter
        private int _id;
        private string _navn;
        private int _kredsId;


        // Konstruktør
        public Roller()
        {
            Id = 0;
            Navn = "";
            KredsId = 0;
        }

        public Roller(int id, string navn, int kredsId)
        {
            Id = id;
            Navn = navn;
            KredsId = kredsId;
        }

        //properties

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }


        public int KredsId
        {
            get { return _kredsId; }
            set { _kredsId = value; }
        }

        public override string ToString()
        {
            return "Id: " + Id + "Navn: " + Navn + "KredsId: " + KredsId;
        }


    }
}



