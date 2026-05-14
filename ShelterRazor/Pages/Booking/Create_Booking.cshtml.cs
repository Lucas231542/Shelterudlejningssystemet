using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using ShelterudlejningssystemetLib;
namespace ShelterRazor.Pages.Booking;

public class Create_Booking : PageModel
{
    private string _FejlBesked;
    private int _bookingId;
    private DateTime _startDato;
    private DateTime _slutDato;
    private int _antalMennesker;

    public string FejlBesked
    {
        get { return _FejlBesked; }
        set { _FejlBesked = value; }
    }

    [BindProperty]
    public int BookingId
    {
        get{ return _bookingId; }
        set { _bookingId = value; }
    }

    [BindProperty]
    public DateTime StartDato
    {
        get { return _startDato; }
        set { _startDato = value; }
    }

    [BindProperty]
    public DateTime SlutDato
    {
        get { return _slutDato; }
        set { _slutDato  = value; }
    }

    [BindProperty]
    public int AntalMennesker
    {
        get { return _antalMennesker; }
        set { _antalMennesker = value; }
    }

    public void OnGet()
    {
        
    }
    
    public IActionResult OnPost()   
    {
        if (SlutDato < StartDato)
        {
            FejlBesked = "SlutDato må ikke være før startDato.";
            return Page();
        }
        var booking = new ShelterudlejningssystemetLib.Booking(BookingId, StartDato, SlutDato, AntalMennesker, "Ukendt Kreds");
        
        ShelterudlejningssystemetLib.Booking.TilføjBooking(booking);
        
        return RedirectToPage("/Booking/Index_Booking");    
    }
}