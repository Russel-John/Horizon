using System;

namespace HorizonBookingSystem
{
    public class BookingViewModel
    {
        public int BookingID { get; set; }
        public string Route { get; set; }
        public string FlightDate { get; set; }
        public string FlightTime { get; set; }
        public int? Tickets { get; set; }
        public string Seats { get; set; }
        public string TotalPrice { get; set; }
        public string BookedOn { get; set; }
    }
}