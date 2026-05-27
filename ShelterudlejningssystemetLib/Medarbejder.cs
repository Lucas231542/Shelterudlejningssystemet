namespace ShelterudlejningssystemetLib;

public class Medarbejder: Bruger
{
    private ISpejderKredsService _spejderKredsService;

    private string _stilling;
    
    public Medarbejder (int id, string name, int tlf, string email, string stilling)
        :base(id, name, tlf, email) 
    {
        _spejderKredsService  = new SpejderKredsService();
        _stilling    = stilling;
    }

    public string Stilling
    {
        get { return _stilling; }
        set { _stilling = value; }
    }
    // Metode til at hente alle Spejderkredse ved brug af servicen 
    public List<SpejderKreds> hentAlleSpejderKredse()
    {
      return  _spejderKredsService.GetAll();


    }

    public override string ToString()
    {
        return $"Medarbejder - {base.ToString()}";
    }
}