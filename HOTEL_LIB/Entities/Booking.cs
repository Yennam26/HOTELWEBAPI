using System;
using System.Collections.Generic;

namespace HOTEL_LIB.Entities;

public partial class Booking
{
    public int BookingId { get; set; }

    public int GuestId { get; set; }

    public int RoomId { get; set; }

    public DateOnly? CheckInDate { get; set; }

    public DateOnly? CheckOutDate { get; set; }

    public decimal? TotalAmount { get; set; }

    public string? BookingStatus { get; set; }

    public virtual Guest Guest { get; set; } = null!;

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual Room Room { get; set; } = null!;
}
