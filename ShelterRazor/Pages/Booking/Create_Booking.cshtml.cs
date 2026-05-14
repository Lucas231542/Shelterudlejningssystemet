using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using ShelterudlejningssystemetLib;
namespace ShelterRazor.Pages.Booking;

public class Create_Booking : PageModel
{
    private string _FejlBesked;

    public string FejlBesked
    {
        get { return _FejlBesked; }
        set { _FejlBesked = value; }
    }
    public void OnGet()
    {
        
    }

    public IActionResult OnPost(int bookingId, DateTime startDato, DateTime slutDato, int antalMennesker)
    {
        if (slutDato < startDato)
        {
            FejlBesked = "SlutDato må ikke være før startDato.";
            return Page();
        }
        var booking = new ShelterudlejningssystemetLib.Booking(bookingId, startDato, slutDato, antalMennesker);
        
        ShelterudlejningssystemetLib.Booking.TilføjBooking(booking);
        
        return RedirectToPage("/Booking/Index_Booking");    
    }
}