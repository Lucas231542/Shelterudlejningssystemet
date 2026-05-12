namespace ShelterudlejningssystemetLib;

public class Medarbejder: Bruger
{
    private ISpejderKredsService _spejderKredsService; 
    
    public Medarbejder (int id, string name, int tlf, string email)
        :base(id, name, tlf, email) 
    {
        
    }
    // Metode til at hente alle Spejderkredse ved brug af servicen 
    public List<SpejderKreds> hentAlleSpejderKredse()
    {
      return  _spejderKredsService.GetAll();


    }
}