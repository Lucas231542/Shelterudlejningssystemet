using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using ShelterudlejningssystemetLib;
namespace ShelterRazor.Pages.Booking;

public class Edit_Booking : PageModel
{
    private int _bookingId;
    private DateTime _startDato;
    private DateTime _slutDato;
    private int _antalMennesker;
    
    [BindProperty]
    public int BookingId
    {
        get { return _bookingId; }
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
        set { _slutDato = value; }
    }

    [BindProperty]
    public int AntalMennesker
    {
        get { return _antalMennesker; }  
                                 
        set { _antalMennesker = value;}  
    }

    public void OnGet(int bookingId)
    {
        foreach ( var b in ShelterudlejningssystemetLib.Booking.HentAlleBookinger())       
        {                                                                                      
            if (b.BookingId == bookingId)                                                      
            {                                                                                  
                BookingId = b.BookingId;                                                       
                StartDato = b.StartDato;                                                       
                SlutDato = b.SlutDato;                                                         
                AntalMennesker = b.AntalMennesker;                                             
            }                                                                                  
        }                                                                                      

    }

    public IActionResult OnPostOk()
    {
        ShelterudlejningssystemetLib.Booking.RedigerBooking(BookingId, StartDato, SlutDato, AntalMennesker);
        return RedirectToPage("/Booking/Index_Booking");
    }

    public IActionResult OnPostCancel()
    {
        return RedirectToPage("/Booking/Index_Booking");
    }
    
       
       
       
       
       
       
       
       
       
       
       
    }
