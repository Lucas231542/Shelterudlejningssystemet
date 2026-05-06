using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ShelterudlejningssystemetLib
// Anton Shelter
{
    public class FDF_Shelter
    {

        // Instansfelter
        private int _shelterId;
        private string _shelterNavn;
        private int _lokation;
        private int _størrelse;


        // Konstruktør
        public FDF_Shelter()
        {
            ShelterId = 0;
            ShelterNavn = "";
            Lokation = 0;
            Størrelse = 0;
        }

        public FDF_Shelter(int shelterid, string shelternavn, int lokation, int størrelse)
        {
            ShelterId = shelterid;
            ShelterNavn = shelternavn;
            Lokation = lokation;
            Størrelse = størrelse;

        }

        //properties

        public int ShelterId
        {
            get { return _shelterId; }
            set { ShelterId = value; }
        }

        public string ShelterNavn
        {
            get { return _shelterNavn; }
            set { ShelterNavn = value; }
        }

        public int Lokation
        {
            get { return _lokation; }
            set { Lokation = value; } 
        }

        public int Størrelse
        {
            get { return _størrelse; }
            set { Størrelse =value; }
        }

        public override string ToString()
        {
            return "ShelterId: " + ShelterId + "ShelterNavn: " + ShelterNavn + " Lokation: " + Lokation + " Størrelse: " + Størrelse;
        }
    }
}

