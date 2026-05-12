using System.Security.Cryptography.X509Certificates;

namespace ShelterudlejningssystemetLib
{
    public class SpejderKreds
    {
        // instans felter 
        private int _kredsID;
        private string _name;
        private int _medlemmer;
        


        // konstruktør
        public SpejderKreds()
        {
            KredsID = 0;
            Name = "";
            Medlemmer = 0;
           

        }

        public SpejderKreds(int kredsID, string name, int medlemmer)
        {
            KredsID = kredsID;
            Name = name;
            Medlemmer = medlemmer;
           
        }

        // properties

        public int KredsID
        {
            get { return _kredsID; }
            set { _kredsID = value; }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length < 0)
                {
                    throw new ArgumentException("Name cannot be null or empty.");
                }
                _name = value;
            }
        }

        public int Medlemmer
        {
            get { return Medlemmer; }
            set {
                if (value < 0)
                {
                    throw new ArgumentException("Størrelse cannot be negative.");
                }
                _medlemmer = value; }
        }


        // metode
        public override string ToString()
        {
            return $"KredsID: {KredsID}, Name: {Name}, Medlemmer: {Medlemmer}";


        }


    }
}
