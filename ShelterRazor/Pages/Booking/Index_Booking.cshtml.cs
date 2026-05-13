using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using ShelterudlejningssystemetLib;

namespace ShelterRazor.Pages.Booking;

public class Index_Booking : PageModel
{
    public List<ShelterudlejningssystemetLib.Booking> Bookinger { get; set; }
    public void OnGet()
    {
       
        Bookinger = ShelterudlejningssystemetLib.Booking.HentKommendeBookinger();
}
}