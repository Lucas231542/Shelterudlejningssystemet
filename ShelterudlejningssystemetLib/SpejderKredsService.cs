using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ShelterudlejningssystemetLib
{
    public class SpejderKredsService
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

        public SpejderKreds Get(int kredsID)
        {
            foreach (var kreds in Kredse)
            {
                if (kreds.KredsID == kredsID)
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


        public SpejderKreds Remove(int kredsID)
        {
            SpejderKreds kredstoRemove = Get(kredsID);

            _kredse.Remove(kredstoRemove);
            return kredstoRemove; // Return the removed SpejderKreds
        }


        public SpejderKreds Edit(int kredsID, string newName, int newStørrelse)
        {
            SpejderKreds kredsToEdit = Get(kredsID);
            if (kredsToEdit != null)
            {
                kredsToEdit.Name = newName;
                kredsToEdit.Størrelse = newStørrelse;
                return kredsToEdit; // Return the edited SpejderKreds
            }
            return null; // Return null if no matching SpejderKreds is found
        }


        

    }
}
