using HOTEL_LIB.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HOTELWEBAPI.Controllers
{
    public class BookingController : ControllerBase
    {
        private readonly BookingController _bookingController;

        public BookingController(BookingController bookingController)
        {
            _bookingController = bookingController;
        }

        [HttpGet ("GetBookings")]
        public async Task<List<Booking>> GetBookingsAsync()
        {
            return await _bookingController.GetBookingsAsync();
        }
    }
}
