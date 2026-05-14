using Microsoft.AspNetCore.Mvc.RazorPages;
using ShelterudlejningssystemetLib;

namespace ShelterRazor.Pages;


public class Index_Bruger : PageModel
{
    private List<Bruger> _brugere;

    public List<Bruger> Brugere
    {
        get{ return _brugere; }
        set { _brugere = value; }
    }
    public void OnGet()
    {
        _brugere = new List<Bruger>();
        _brugere.Add(new Administrator(1, "Sofyane", 12345678, "Sofyane@Shelter.dk"));
        _brugere.Add(new Administrator(2, "Lucas", 87654321, "Lucas@SHelter.dk"));
        _brugere.Add(new Medarbejder(3, "Aleks", 22453267, "Aleks@Shelter.dk"));
        _brugere.Add(new Medarbejder(4, "Ahmed", 26885642, "Ahmed@Shelter.dk"));
        _brugere.Add(new Medarbejder(5, "Anton", 66856743, "Anton@Shelter.dk"));
    }
}