using HOTEL_LIB.HotelModels;

namespace HOTEL_LIB
{
    public interface IHotelDBClass
    {
       public Task<List<Booking>> BookingsAsync();
       public Task<List<Guest>> GetGuestsAsync();
       public Task<List<Payment>> GetPaymentsAsync();
       public Task<List<Room>> GetRoomsAsync();
    }
}