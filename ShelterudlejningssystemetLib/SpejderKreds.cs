namespace ShelterudlejningssystemetLib
{
    public class SpejderKreds
    {
        // instans felter 
        private int _KredsID;
        private string _name;
        private int _Størrelse;



        // konstruktør
        public SpejderKreds()
        {
            KredsID = 0;
            Name= "";
            Størrelse = 0;
        }
        public SpejderKreds(int kredsID, string name, int størrelse)
        {
            KredsID = kredsID;
            name = name;
            Størrelse = størrelse;
        }


        // properties

        public int KredsID
        {
            get { return _KredsID; }
            set { _KredsID = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Størrelse
        {
            get { return _Størrelse; }
            set { _Størrelse = value; }
        }


        public override string ToString()
        {
            return "KredsID: " + KredsID + "Name: " + Name + "Størrelse: " + Størrelse;
        }

    }
}
