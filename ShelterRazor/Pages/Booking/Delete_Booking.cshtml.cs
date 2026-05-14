using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ShelterRazor.Pages.Booking;

public class Delete_Booking : PageModel
{
    private int _bookingID;

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
        ShelterudlejningssystemetLib.Booking.SletBooking(BookingId);
        return RedirectToPage("/Booking/Index_Booking");
    }
}