using System.Security.Cryptography.X509Certificates;

namespace ShelterudlejningssystemetLib
{
    public class SpejderKreds
    {
        // instans felter 
        private int _kredsId;
        private string _name;
        private int _medlemmer;
        


        // konstruktør
        public SpejderKreds()
        {
            KredsId = 0;
            Name = "";
            Medlemmer = 0;
           

        }

        public SpejderKreds(int kredsID, string name, int medlemmer)
        {
            KredsId = kredsID;
            Name = name;
            Medlemmer = medlemmer;
           
        }

        // properties

        public int KredsId
        {
            get { return _kredsId; }
            set { _kredsId = value; }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name kan ikke være null eller tom.");
                }
                _name = value;
            }
        }

        public int Medlemmer
        {
            get { return _medlemmer; }
            set {
                if (value < 0)
                {
                    throw new ArgumentException("Antal kan ikke være negativt.");
                }
                _medlemmer = value; }
        }


        // metode
        public override string ToString()
        {
            return $"KredsID: {KredsId}, Name: {Name}, Medlemmer: {Medlemmer}";

        }


    }
}
