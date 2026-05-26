using ShelterudlejningssystemetLib;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ShelterudlejningssystemetLib
 
{
    public class Log
    {
        // Instans felter 
        private int _id;
        private DateTime _startdato;
        private DateTime _slutdato;
        private string _tekst;
        private int _shelterId;     

        // Konstruktør
        public Log()
        {
            Id = 0;
            Startdato = DateTime.Now;
            Slutdato = DateTime.Now;
            Tekst = "";
            ShelterId = 0;

         // Konstruktør med paramtre
        }
        public Log(int id, DateTime startdato, DateTime slutdato, string tekst, int shelterId)
        {
            Id = id;
            Startdato = startdato;
            Slutdato = slutdato;
            Tekst = tekst;
            ShelterId = shelterId;

         // Properties
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public DateTime Startdato
        {
            get { return _startdato; }
            set { _startdato = value; }
        }
        public DateTime Slutdato
        {
            get { return _slutdato; }
            set
            {
                if (value < Startdato)
                    throw new ArgumentException("Slutdato må ikke være før startdato");
                _slutdato = value;
            }
        }

        public string Tekst
        {
            get { return _tekst; }
            set { _tekst = value; }
        }
        public int ShelterId
        {
            get { return _shelterId; }
            set { _shelterId = value; }
        }

        // Metode der laver objekt om til tekst
        public override string ToString()
        {
            return "Id:" + Id + ", Startdato:" + Startdato + ", Slutdato:" + Slutdato + ", Tekst:" + Tekst + ", ShelterId:" + ShelterId;
        }
        }
    }
