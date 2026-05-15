using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using ShelterudlejningssystemetLib;
using BookingLib = ShelterudlejningssystemetLib.Booking;

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
        if (ShelterudlejningssystemetLib.Booking.HentAlleBookinger().Count == 0)

        {
            BookingLib.TilføjBooking(new BookingLib(1, DateTime.Now.AddDays(5), DateTime.Now.AddDays(7), 10,
                "København Kreds"));
            BookingLib.TilføjBooking(new BookingLib(2, DateTime.Now.AddDays(10), DateTime.Now.AddDays(12), 5,
                "Roskilde Kreds"));
            BookingLib.TilføjBooking(new BookingLib(3, DateTime.Now.AddDays(20), DateTime.Now.AddDays(22), 8,
                "Køge Kreds"));

            
        }
        Bookinger = ShelterudlejningssystemetLib.Booking.HentKommendeBookinger();
    }
}