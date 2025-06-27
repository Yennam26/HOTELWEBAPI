using HOTEL_LIB.HotelModels;
using Microsoft.EntityFrameworkCore;

namespace HOTEL_LIB
{
    public class HotelDBClass : IHotelDBClass
    {
        private readonly HotelContext _Hotelcontext;

        public HotelDBClass(HotelContext hotelContext)
        {
            _Hotelcontext = hotelContext;
        }

        public async Task<List<Booking>> BookingsAsync()
        {
            return await _Hotelcontext.Bookings
                .Select(b => new Booking
                {
                    BookingId = b.BookingId,
                    GuestId = b.GuestId,
                    RoomId = b.RoomId,
                    CheckInDate = b.CheckInDate,
                    CheckOutDate = b.CheckOutDate,
                    TotalAmount = b.TotalAmount,
                    BookingStatus = b.BookingStatus
                }).ToListAsync();
        }

        public async Task<List<Guest>> GetGuestsAsync()
        {
            return await _Hotelcontext.Guests
                .Select(g => new Guest
                {
                    GuestId = g.GuestId,
                    FullName = g.FullName,
                    PhoneNumber = g.PhoneNumber,
                    Email = g.Email,
                    Address = g.Address,
                    IdproofType = g.IdproofType,
                    IdproofNumber = g.IdproofNumber
                }).ToListAsync();
        }

        public async Task<List<Payment>> GetPaymentsAsync()
        {
            return await _Hotelcontext.Payments
                .Select(p => new Payment
                {
                    PaymentId = p.PaymentId,
                    BookingId = p.BookingId,
                    PaymentDate = p.PaymentDate,
                    AmountPaid = p.AmountPaid,
                    PaymentMethod = p.PaymentMethod
                }).ToListAsync();
        }

        public async Task<List<Room>> GetRoomsAsync()
        {
            return await _Hotelcontext.Rooms
                .Select(r => new Room
                {
                    RoomId = r.RoomId,
                    RoomNumber = r.RoomNumber,
                    RoomType = r.RoomType,
                    BedCount = r.BedCount,
                    PricePerNight = r.PricePerNight,
                    IsAvailable = r.IsAvailable
                }).ToListAsync();
        }
    }
}