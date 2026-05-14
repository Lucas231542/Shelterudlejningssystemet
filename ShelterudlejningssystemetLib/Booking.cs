using System;
using System.Collections.Generic;
using System.Text;

namespace ShelterudlejningssystemetLib
{
    public class Booking
    {
        // Private variabler 

        private int _bookingId;
        private DateTime _startDato;
        private DateTime _slutDato;
        private int _antalMennesker;
        private string _kredsNavn;

        // liste over alle bookinger 

        private static List<Booking> _alleBookinger = new List<Booking>();

        // Konstruktør 
        public Booking()
        {
            _bookingId = 0;
            _startDato = DateTime.Now;
            _slutDato = DateTime.Now;
            _antalMennesker = 0;
            _kredsNavn = "";
        }
        // Konstruktør  

        public Booking(int bookingId, DateTime startDato, DateTime slutDato, int antalMennesker, string KredsNavn)
        {
            _bookingId = bookingId;
            _startDato = startDato;
            _slutDato = slutDato;
            _antalMennesker = antalMennesker;
            _kredsNavn = KredsNavn;
        }

        // Properties 
        public int BookingId
        {
            get { return _bookingId; }
            set { _bookingId = value; }
        }

        public DateTime StartDato
        {
            get { return _startDato; }
            set { _startDato = value; }
        }

        public DateTime SlutDato
        {
            get { return _slutDato; }
            set
            {
                if (value < _startDato)
                {
                    throw new ArgumentException("SlutDato cannot be before StartDato.");
                }

                _slutDato = value;
            }
        }

        public int AntalMennesker
        {
            get { return _antalMennesker; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("AntalMennesker value can't be negative");
                }

                _antalMennesker = value;
            }
        }

        public string KredsNavn
        {
            get { return _kredsNavn; }
            set { _kredsNavn = value; }
        }

        // Returnerer en liste over bookinger der endnu ikke er startet
        public static List<Booking> HentKommendeBookinger()
        {
            List<Booking> kommendeBookinger = new List<Booking>();
            foreach (Booking b in _alleBookinger)
            {
                if (b.StartDato > DateTime.Now)
                {
                    kommendeBookinger.Add(b);
                }
            }

            return kommendeBookinger;
        }

        public static List<Booking> HentAlleBookinger()
        {
            return _alleBookinger;
        }


        // Tilføjer en booking til listen over alle bookinger 
        public static void TilføjBooking(Booking booking)
        {
            _alleBookinger.Add(booking);
        } 
        
        // Sletter en booking fra listen baseret på bookingId 

        public static void SletBooking(int bookingId)
        {
            _alleBookinger.RemoveAll(b => b.BookingId == bookingId);
        }

        // Redigere en eksisterende booking med nye værdier 
        public static void RedigerBooking(int bookingId, DateTime nyStartDato, DateTime nySlutDato,
            int nyAntalMennekser)
        {
            foreach (Booking b in _alleBookinger)
            {
                if (b.BookingId == bookingId)
                {
                    b.StartDato = nyStartDato;
                    b.SlutDato = nySlutDato;
                    b.AntalMennesker = nyAntalMennekser;
                }
            }
        }

        // Metoder
        public override string ToString()
        {
            return
                $"BookingId: {BookingId}, StartDato: {StartDato}, SlutDato: {SlutDato}, AntalMennesker: {AntalMennesker}";
        }
    }
}