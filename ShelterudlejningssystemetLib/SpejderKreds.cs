using System.Security.Cryptography.X509Certificates;

namespace ShelterudlejningssystemetLib
{
    public class SpejderKreds
    {
        // instans felter 
        private int _kredsID;
        private string _name;
        private int _størrelse;
        
        private List<Blog_opslag> _begivenheder;



        // konstruktør
        public SpejderKreds()
        {
            KredsID = 0;
            Name = "";
            Størrelse = 0;
            _begivenheder = new List<Blog_opslag>();
        }

        public SpejderKreds(int kredsID, string name, int størrelse, List<Blog_opslag> begivenheder)
        {
            KredsID = kredsID;
            Name = name;
            Størrelse = størrelse;
            _begivenheder = begivenheder;
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

        public List<Blog_opslag> Begivenheder
        {
            get { return _begivenheder; }
            set { _begivenheder = value; }
        }

        //metoder
        public override string ToString()
        {
            return $"KredsID: {KredsID}, Name: {Name}, Størrelse: {Størrelse}";


        }


        // KredsLeder tilføje en begivenhed til kredsens blog
        public void AddEvent(Blog_opslag NewEvent)
        {
            _begivenheder.Add(NewEvent);
        }

        // KredsLeder slette en begivenhed fra kredsens blog
        public void RemoveEvent(int EventToRemove)
        {
            Blog_opslag begivenhed = GetEvent(EventToRemove);
            if (begivenhed != null)
            {
                _begivenheder.Remove(begivenhed);
            }
           
        }
        // KredsLeder hente alle begivenheder fra kredsens blog
        public List<Blog_opslag> ListAll()
        {
            return new List<Blog_opslag>(_begivenheder);
        }

        // KredsLeder hente en begivenhed fra kredsens blog
        public Blog_opslag GetEvent(int BlogId)
        {
            Blog_opslag resBegivenhed = null; // Return null if not found
            foreach (Blog_opslag b in _begivenheder)
            {
                if (b.Id == BlogId)
                {
                    return b; // Return the found event
                }
            }
            return resBegivenhed;
        }

        // opdatere en begivenhed i kredsens blog
        public Blog_opslag UpdateBegivenhed(int BlogId, Blog_opslag updatedBegivenhed)
        {
            Blog_opslag begivenhed = GetEvent(BlogId);
            if (begivenhed != null)
            {
                begivenhed.Id = updatedBegivenhed.Id;
                begivenhed.Titel = updatedBegivenhed.Titel;
                begivenhed.Tekst = updatedBegivenhed.Tekst;
                begivenhed.Dato = updatedBegivenhed.Dato;
            }
            return begivenhed;
        }

    }
}
