using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShelterudlejningssystemetLib;

namespace ShelterRazor.Pages.Booking;

public class Delete_Booking : PageModel
{
    private int _bookingID;
 private BookingListe _bookingListe;

 public Delete_Booking(BookingListe bookingListe)
 {
     _bookingListe = bookingListe;
 }
 
    [BindProperty]
    public int BookingId
    {
        get { return _bookingID; }
        set { _bookingID = value; }
    }
    
    public void OnGet(int ? bookingID)
    {
        BookingId = BookingId;
    }

    public IActionResult OnPostSlet()
    {
        _bookingListe.SletBooking(BookingId);
        return RedirectToPage("/Booking/Index_Booking");
    }
}