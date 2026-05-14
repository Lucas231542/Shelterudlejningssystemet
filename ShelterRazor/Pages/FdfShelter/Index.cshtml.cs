using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShelterudlejningssystemetLib;

namespace ShelterRazor.Pages.FdfShelter
{
    public class IndexModel : PageModel
    {
        public List<FDF_Shelter> Shelters { get; set; } = new List<FDF_Shelter>();
        public void OnGet()
        {
            //Test data

    

            FDF_Shelter shelter1 = new FDF_Shelter(1, "Den Store Bjørn", "Ganløse", 5, 3660);
            FDF_Shelter shelter2 = new FDF_Shelter(2, "Det Skæve Æsel", "Ganløse", 5, 3660);

            shelter1.TilføjBooking (new ShelterudlejningssystemetLib.Booking()
            {
                BookingId = 1,
                StartDato =  new DateTime (2026, 5, 17),
                SlutDato = new DateTime (2026, 5, 24)
            });

            shelter2.TilføjBooking (new ShelterudlejningssystemetLib.Booking()
            {
                BookingId = 2,
                StartDato = new DateTime(2026, 5, 17),
                SlutDato = new DateTime(2026, 5, 24)
            });

            Shelters.Add (shelter1);
            Shelters.Add (shelter2);
                
        
        }
    }
}
