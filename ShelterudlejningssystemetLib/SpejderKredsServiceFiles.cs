using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text;

namespace ShelterudlejningssystemetLib
{
    public class SpejderKredsServiceFiles:ISpejderKredsService
    {
        //aggregation class for SpejderKreds
        private List<SpejderKreds> _kredse;


        // constructor
        public SpejderKredsServiceFiles()
        {
            Kredse = new List<SpejderKreds>();
            LoadFromFile();
        }

        public SpejderKredsServiceFiles(List<SpejderKreds> kredse)
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
            SaveToFile();
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
            SaveToFile();
            return kredstoRemove; // Return the removed SpejderKreds
        }


        public SpejderKreds Edit(int kredsID, string newName, int newStørrelse)
        {
            SpejderKreds kredsToEdit = Get(kredsID);
            if (kredsToEdit != null)
            {
                kredsToEdit.Name = newName;
                kredsToEdit.Medlemmer = newStørrelse;
                SaveToFile();
                return kredsToEdit; // Return the edited SpejderKreds
            }
            return null; // Return null if no matching SpejderKreds is found
        }

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

        private void LoadFromFile()
        {
            try
            {
                StreamReader sr = new StreamReader(@"C:\Users\lucas\OneDrive - Zealand\Documents\Zealand lokalt\eksamensProjekt 1 semester\Shelterudlejningssystemet\Datafiler.json");
                string jsonStr = sr.ReadLine();
                List<SpejderKreds> kredse = JsonSerializer.Deserialize<List<SpejderKreds>>(jsonStr);
                sr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("kan ikke læse filen: " + ex.Message);
                _kredse = new List<SpejderKreds>(); // Initialize an empty list if the file cannot be read
            }
            }

        private void SaveToFile()
        {
            string jsonStr = JsonSerializer.Serialize(_kredse);
            StreamWriter sw = new StreamWriter("kredse.json");
            sw.Write(jsonStr);
            sw.Close();
        }
    }
}
