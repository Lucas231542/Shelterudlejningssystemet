namespace ShelterudlejningssystemetLib;

public class Bruger
{
    private int _id;
    private string _name;
    private int _tlf;
    private string _email;

    public Bruger(int id, string name, int tlf, string email)
    {
        _id = id;
        _name = _name;
        _tlf =  tlf;
        _email = _email;

    }

    public int id
    {
        get { return _id; }
        set { _id = value; }
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public int tlf
    {
        get { return _tlf; }
        set { _tlf = value; }
    }

    public string Email
    {
        get { return _email; }
        set { _email = value; }
    }
    
    public override string ToString ()
    {
        return 
        $"id: {id}, name: {Name}, tlf: {tlf}, email: {Email} ";
    }
}