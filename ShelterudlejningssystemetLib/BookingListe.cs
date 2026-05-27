namespace ShelterudlejningssystemetLib;

public class BookingListe
{
    private List<Booking> _alleBookinger = new List<Booking>();

    public List<Booking> HentAlleBookinger()
    {
        return _alleBookinger;
    }

    public List<Booking> HentKommendeBookinger()
    {
        List<Booking> KommendeBookinger = new List<Booking>();
        foreach (Booking b in _alleBookinger)
        if (b.StartDato > DateTime.Now)
        {
            KommendeBookinger.Add(b);   
        }
        return KommendeBookinger;
    }
       

    public void TilføjBooking(Booking booking)
    {
        _alleBookinger.Add(booking);
    }

    public void SletBooking(int BookingId)
    {
        _alleBookinger.RemoveAll(b => b.BookingId == BookingId);
    }

    public void RedigerBooking(int BookingId, DateTime nyStartDato, DateTime nySlutDato, int nyAntalMennesker)
    {
        foreach (Booking b in _alleBookinger)
        {
            if (b.BookingId == BookingId)
            {
                b.StartDato = nyStartDato;
                b.SlutDato = nySlutDato;
                b.AntalMennesker = nyAntalMennesker;
            }
        }
    }
}