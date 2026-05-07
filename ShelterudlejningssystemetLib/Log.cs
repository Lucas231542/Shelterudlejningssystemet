using ShelterudlejningssystemetLib;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ShelterudlejningssystemetLib
//Aleks Log 
{
    public class Log
    {
        private int _id;
        private DateTime _startdato;
        private DateTime _slutdato;
        private string _tekst;

        private static List<Log> _alleLogs = new List<Log>();
        public Log()
        {
            Id = 0;
            Startdato = DateTime.Now;
            Slutdato = DateTime.Now;
            Tekst = "";
        }
        public Log(int id, DateTime startdato, DateTime slutdato, string tekst)
        {
            Id = id;
            Startdato = startdato;
            Slutdato = slutdato;
            Tekst = tekst;
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
        public static void TilføjLog(Log log)
        {
            _alleLogs.Add(log);
        }
        public static List<Log> HentAlleLogs()
        {
            return new List<Log>(_alleLogs);
        }
        public static void SletLog(int id)
        {
            _alleLogs.RemoveAll(l => l.Id == id);
        }
        public static Log HentLog(int id)
        {
            foreach (Log log in _alleLogs)
            {
                if (log.Id == id)
                {
                    return log;

                }
            }
            return null;
        }
        public static void RedigerLog(int id, DateTime nyStartdato, DateTime nySlutdato, string nyTekst)
        {
            Log log = HentLog(id);
            if (log != null)
            {
                log.Startdato = nyStartdato;
                log.Slutdato = nySlutdato;
                log.Tekst = nyTekst;
            }
        }
        public override string ToString()
        {
            return "Id:" + Id + ", Startdato:" + Startdato + ", Slutdato:" + Slutdato + ", Tekst:" + Tekst;
        }
        }
    }
