using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ShelterudlejningssystemetLib
{
    public class LogService
    {
        private List<Log> _logs;

        public LogService()
        {
            _logs  = new List<Log>();
        }
        public void Addlog(Log log)
        {
            _logs.Add(log);
        }
        public List <Log> GetAll()
        {
            return new List<Log>(_logs);
        }
        public void DeleteLog(int id)
        {
            _logs.RemoveAll(l => l.Id == id);
        }
        public Log GetById(int id)
        {
            foreach (Log log in _logs)
            {
                if (log.Id == id)
                {
                    return log; 
                }
            }
            return null;
            }
        public void EditLog(int id, DateTime nyStartdato, DateTime nySlutdato, string nyTekst)
        {
            Log log = GetById(id);

            if (log != null)
            {
                log.Startdato = nyStartdato;
                log.Slutdato = nySlutdato;
                log.Tekst = nyTekst;
            }
        }
 
        }
    }

