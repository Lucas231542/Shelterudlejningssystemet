namespace ShelterudlejningssystemetLib;
// Admin arver fra Bruger klassen (Arver variabler, properties og metoder)
public class Administrator: Bruger
{
    private ISpejderKredsService _spejderKredsService;

    private int _adgangsniveau;
    
    public Administrator(int id, string name, int tlf, string email, int adgangsniveau)
    : base(id, name, tlf, email)
    
    {
        _spejderKredsService = new SpejderKredsService();
        _adgangsniveau = adgangsniveau;
    }

    public int Adgangsniveau
    {
        get { return _adgangsniveau; }
        set { _adgangsniveau = value; }
    }

    // Metode til at oprette en kreds bed brug af servicen 
    public void OpretKreds(SpejderKreds kreds)
    {
        _spejderKredsService.AddKreds(kreds);
        
    }

    public override string ToString()
    {
        return $"Administrator - {base.ToString()}";
    }
}