namespace ShelterudlejningssystemetLib;
// Admin arver fra Bruger klassen (Arver variabler, properties og metoder)
public class Administrator: Bruger
{
    private ISpejderKredsService _spejderKredsService;
    
    public Administrator(int id, string name, int tlf, string email)
    : base(id, name, tlf, email)
    
    {
        _spejderKredsService = new SpejderKredsService();
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