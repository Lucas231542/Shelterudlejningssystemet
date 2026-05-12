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
            return new List<SpejderKreds>(Kredse);
        }


        public SpejderKreds Remove(int kredsId)
        {
            SpejderKreds kredstoRemove = Get(kredsId);

            _kredse.Remove(kredstoRemove);
            return kredstoRemove; // Return the removed SpejderKreds
        }


        public SpejderKreds Edit(int kredsId, string newName, int newStørrelse)
        {
            SpejderKreds kredsToEdit = Get(kredsId);
            if (kredsToEdit != null)
            {
                kredsToEdit.Name = newName;
                kredsToEdit.Medlemmer = newStørrelse;
                return kredsToEdit; // Return the edited SpejderKreds
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
