using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using ShelterudlejningssystemetLib;

namespace ShelterRazor.Pages.Booking;

public class Index_Booking : PageModel
{
    private List<ShelterudlejningssystemetLib.Booking> _bookinger;
    public List<ShelterudlejningssystemetLib.Booking> Bookinger 
    {
        get { return _bookinger; }
        set { _bookinger = value; }
    }
    
    
    public void OnGet()
    {

        Bookinger = ShelterudlejningssystemetLib.Booking.HentAlleBookinger();
    }
}