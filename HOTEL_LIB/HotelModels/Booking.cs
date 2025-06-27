using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL_LIB.HotelModels
{
    public  class Booking
    {
        public int BookingId { get; set; }

        public int GuestId { get; set; }

        public int RoomId { get; set; }

        public DateOnly? CheckInDate { get; set; }

        public DateOnly? CheckOutDate { get; set; }

        public decimal? TotalAmount { get; set; }

        public string? BookingStatus { get; set; }
    }
}
