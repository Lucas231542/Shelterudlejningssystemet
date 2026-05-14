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
                if (kreds.KredsId == kredsID)
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
            SpejderKreds s = Get(kredsId);
            if (s != null)
            {
                Kredse.Remove(s);
                SaveToFile();
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
                SaveToFile();
                return s; // Return the edited SpejderKreds
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
               StreamReader sr = new StreamReader("Datafiler.json");
                string jsonStr = sr.ReadToEnd();
                List<SpejderKreds> kredse = JsonSerializer.Deserialize<List<SpejderKreds>>(jsonStr);
                _kredse = kredse;
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
            StreamWriter sw = new StreamWriter("Datafiler.json");
            sw.Write(jsonStr);
            sw.Close();
        }


    }
}
