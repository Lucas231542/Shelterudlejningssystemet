using System.Security.Cryptography.X509Certificates;

namespace ShelterudlejningssystemetLib
{
    public class SpejderKreds
    {
        // instans felter 
        private int _kredsID;
        private string _name;
        private int _størrelse;
        private List<SpejderKreds> _kredse;


        // konstruktør
        public SpejderKreds()
        {
            KredsID = 0;
            Name = "";
            Størrelse = 0;
            Kredse = new List<SpejderKreds>();

        }

        public SpejderKreds(int kredsID, string name, int størrelse, List<SpejderKreds> kredse)
        {
            KredsID = kredsID;
            Name = name;
            Størrelse = størrelse;
            Kredse = kredse;
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


        public override string ToString()
        {
            return $"KredsID: {KredsID}, Name: {Name}, Størrelse: {Størrelse}";


        }



    }
}
