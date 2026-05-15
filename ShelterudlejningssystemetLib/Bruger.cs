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
        _name = name;
        _tlf =  tlf;
        _email = email;

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

    public string FormatTlf()
    {
        string tlf =_tlf.ToString();
        return tlf.Substring(0, 2) + " " + tlf.Substring(2, 2) + " " + tlf.Substring(4, 2) + " " + tlf.Substring(6, 2);
    }
    
    public override string ToString ()
    {
        return 
        $"id: {id}, name: {Name}, tlf: {tlf}, email: {Email} ";
    }
}