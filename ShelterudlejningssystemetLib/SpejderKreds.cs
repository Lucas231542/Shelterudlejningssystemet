using System.Security.Cryptography.X509Certificates;

namespace ShelterudlejningssystemetLib
{
    public class SpejderKreds
    {
        // instans felter 
        private int _kredsID;
        private string _name;
        private int _størrelse;
        private List<> _spejdere;


        // konstruktør
        public SpejderKreds()
        {
            KredsID = 0;
            Name = "";
            Størrelse = 0;
          
        }

        public SpejderKreds(int kredsID, string name, int størrelse)
        {
            KredsID = kredsID;
            Name = name;
            Størrelse = størrelse;
          
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

        public int Størrelse
        {
            get { return _størrelse; }
            set {
                if (value < 0)
                {
                    throw new ArgumentException("Størrelse cannot be negative.");
                }
                _størrelse = value; }
        }

      

        //metoder
        public override string ToString()
        {
            return $"KredsID: {KredsID}, Name: {Name}, Størrelse: {Størrelse}";


        }







    }
}
