using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ShelterudlejningssystemetLib
{
    // Klasse der håndtere Logs
    public class LogService
    {
        // Liste der gemmer alle Logs
        private static List<Log> _logs = new List<Log>();

        // Konstruktør 
        public LogService()
        {
            if (_logs.Count == 0)
            {
                _logs.Add(new Log(
                    1,
                    DateTime.Now,
                    DateTime.Now.AddDays(1),
                    "Spejdertur i skoven",
                    101));
                _logs.Add(new Log(
                    2,
                    DateTime.Now.AddDays(2),
                    DateTime.Now.AddDays(3),
                    "Bålaften med kredsen",
                    102));
            }
        }

        // Metode til at tilføje en Log 
        public void Addlog(Log log)
        {
            _logs.Add(log);
        }
        // Metode der retunerer alle Logs
        public List <Log> GetAll()
        {
            return new List<Log>(_logs);
        }
        // Metode til at slette en Log via id
        public void DeleteLog(int id)
        {
            _logs.RemoveAll(l => l.Id == id);
        }
        // Metode der finder en Log via id
        public Log GetById(int id)
        {
            foreach (Log log in _logs)
            {
                // Tjekker om id passer 
                if (log.Id == id)
                {
                    return log; 
                }
            }
            // Retunerer null hvis Log ikke findes 
            return null;
            }
        public void EditLog(int id, DateTime nyStartdato, DateTime nySlutdato, string nyTekst)
        {
            // Finder Loggen 
            Log log = GetById(id);

            // Tjekker om Log findes 
            if (log != null)
            {
                log.Startdato = nyStartdato;
                log.Slutdato = nySlutdato;
                log.Tekst = nyTekst;
            }
        }
 
        }
    }

