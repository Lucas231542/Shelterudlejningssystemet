using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ShelterudlejningssystemetLib
// Anton Shelter
{
    public class FDF_Shelter
    {

        // Instansfelter gemmer data om shelter
        private int _shelterId;
        private string _shelterNavn;
        private string _lokation;
        private int _postNummer;
        private int _størrelse;
        private List<Booking> _bookinger;
     


        // Konstruktør 
        public FDF_Shelter() // tom konstruktør bruges til razor pages
        {
            ShelterId = 0;
            ShelterNavn = "";
            Lokation = "";
            Størrelse = 0;
            PostNummer = 0;
            Bookinger = new List<Booking>();
          

        }
        // Opretter shelter med værdier
        public FDF_Shelter(int shelterId, string shelterNavn, string lokation, int størrelse, int postNummer)
        {
            ShelterId = shelterId;
            ShelterNavn = shelterNavn;
            Lokation = lokation;
            Størrelse = størrelse;
            PostNummer = postNummer;
            Bookinger = new List<Booking>();
        }

        //properties

        public int ShelterId
        {
            get { return _shelterId; }
            set {
                if (value < 0)
                    throw new ArgumentException("ShelterID skal have en positiv værdi");
                
                _shelterId = value; }
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
            set
            {
                if (value < 0)
                    throw new ArgumentException("postnummer skal være positivt");
                
                
                _postNummer = value; }
        }

        public int Størrelse
        {
            get { return _størrelse; }
            set {
                if (value < 0)
                    throw new ArgumentException("Størrelse skal være positiv");
                
                _størrelse = value; }
        }


        public List<Booking> Bookinger //Liste med shelterbooking
        {
            get { return _bookinger; }
            set { _bookinger = value; }
        }

        
        public override string ToString() // returnerer shelter information
        {
            return " ShelterId: " + ShelterId + " ShelterNavn: " + ShelterNavn + " Lokation: " + Lokation + " Størrelse: " + Størrelse + " PostNummer: " + PostNummer;
        }

        public bool TilføjBooking(Booking booking)  // Tilføjer booking hvis periode er ledig
        {

            if (booking == null) return false;

            if (ErLedigPeriode(booking.StartDato, booking.SlutDato))
            {
                Bookinger.Add(booking);
                return true;
            }

            return false;
        }

        public bool ErLedigPeriode(DateTime start, DateTime slut) // tjekker om shelter er ledigt  i periode
        {
            if (start > slut)
            {
                return false;
            }

            foreach (Booking booking in Bookinger)
            {
                if (start <= booking.SlutDato && slut >= booking.StartDato)
                {
                    return false;
                }
            }
            return true;
        }

        public  List<Booking> HentBookinger() // returnere en liste over bookinger
        {
            return new List<Booking>(Bookinger);
        }

     
    }
}

