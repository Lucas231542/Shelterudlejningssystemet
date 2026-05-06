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
        private string _lokation;
        private int _postNummer;
        private int _størrelse;



        // Konstruktør
        public FDF_Shelter()
        {
            ShelterId = 0;
            ShelterNavn = "";
            Lokation = "";
            Størrelse = 0;
            PostNummer = 0;
        }

        public FDF_Shelter(int shelterId, string shelterNavn, string lokation, int størrelse, int postNummer)
        {
            ShelterId = shelterId;
            ShelterNavn = shelterNavn;
            Lokation = lokation;
            Størrelse = størrelse;
            PostNummer = postNummer;

        }

        //properties

        public int ShelterId
        {
            get { return _shelterId; }
            set { _shelterId = value; }
        }

        public string ShelterNavn
        {
            get { return _shelterNavn; }
            set { _shelterNavn = value; }
        }

        public string Lokation
        {
            get { return _lokation; }
            set { _lokation = value; } 
        }

        public int PostNummer
        {
            get { return _postNummer; }
            set { _postNummer = value; }
        }

        public int Størrelse
        {
            get { return _størrelse; }
            set { _størrelse =value; }
        }

        public override string ToString()
        {
            return "ShelterId: " + ShelterId + "ShelterNavn: " + ShelterNavn + " Lokation: " + Lokation + " Størrelse: " + Størrelse + "PostNummer: " + PostNummer;
        }
    }
}

