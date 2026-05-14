using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ShelterudlejningssystemetLib
{
    public class SpejderKredsService : ISpejderKredsService
    {
        //aggregation class for SpejderKreds
        private List<SpejderKreds> _kredse;


        // constructor
        public SpejderKredsService()
        {
            Kredse = new List<SpejderKreds>();
        }

        public SpejderKredsService(List<SpejderKreds> kredse)
        {
            Kredse = kredse;
        }

        public List<SpejderKreds> Kredse
        {
            get { return _kredse; }
            set { _kredse = value; }
        }




        //metoder


        public void AddKreds(SpejderKreds newKreds)
        {
            Kredse.Add(newKreds);
        }

        public SpejderKreds Get(int kredsId)
        {
            foreach (var kreds in Kredse)
            {
                if (kreds.KredsId == kredsId)
                {
                    return kreds;
                }
            }
            return null; // Return null if no matching SpejderKreds is found
        }

        public List<SpejderKreds> GetAll()
        {
            return new List<SpejderKreds>(_kredse);
        }


        public SpejderKreds Remove(int kredsId)
        {
            SpejderKreds s = Get(kredsId);
            if (s != null)
            {
                Kredse.Remove(s);
                return s; // Return the removed SpejderKreds
            }
            return null; // Return null if no matching SpejderKreds is found

        }


        public SpejderKreds Edit(int kredsId, string newName, int newStørrelse)
        {
            SpejderKreds s = Get(kredsId);
            if (s != null)
            {
                s.Name = newName;
                s.Medlemmer = newStørrelse;
                return s; // Return the edited SpejderKreds
            }
            return null; // Return null if no matching SpejderKreds is found
        }


        // To String 

        public override string ToString()
        {
            string resultatStr = "SpejderKredsService: \n[\n";
            foreach (SpejderKreds S in _kredse)
            {
                resultatStr += S.ToString() + "\n";
            }
            resultatStr = resultatStr + "]";
            return resultatStr;
        }

    }
}
