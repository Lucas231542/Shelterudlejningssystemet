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
            return $"KredsID: {KredsId}, Name: {Name}, Medlemmer: {Medlemmer}";


        }


    }
}
