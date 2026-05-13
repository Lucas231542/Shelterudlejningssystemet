using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using ShelterudlejningssystemetLib;
namespace ShelterRazor.Pages.Booking;

public class Create_Booking : PageModel
{
    public void OnGet()
    {
        
    }

    public IActionResult OnPost(int bookingId, DateTime startDato, DateTime slutDato, int antalMennesker)
    {
        var booking = new ShelterudlejningssystemetLib.Booking(bookingId, startDato, slutDato, antalMennesker);
        
        ShelterudlejningssystemetLib.Booking.TilføjBooking(booking);
        
        return RedirectToPage("/Booking/Index_Booking");    
    }
}