using System;
using System.Collections.Generic;

namespace HOTEL_LIB.Entities;

public partial class Payment
{
    public int PaymentId { get; set; }

    public int BookingId { get; set; }

    public DateTime? PaymentDate { get; set; }

    public decimal? AmountPaid { get; set; }

    public string? PaymentMethod { get; set; }

    public virtual Booking Booking { get; set; } = null!;
}
