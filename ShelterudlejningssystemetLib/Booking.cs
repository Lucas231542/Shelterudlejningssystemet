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
                if (value < 0 || value > 5)
                {
                    throw new ArgumentException("AntalMennesker value must be between 0 and 5.");
                }

                _antalMennesker = value;
            }
        }

        public string KredsNavn
        {
            get { return _kredsNavn; }
            set { _kredsNavn = value; }
        }


        // Metoder
        public override string ToString()
        {
            return
                $"BookingId: {BookingId}, StartDato: {StartDato}, SlutDato: {SlutDato}, AntalMennesker: {AntalMennesker}";
        }
    }
}