using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL_LIB.HotelModels
{
    public class Payment
    {
        public int PaymentId { get; set; }

        public int BookingId { get; set; }

        public DateTime? PaymentDate { get; set; }

        public decimal? AmountPaid { get; set; }

        public string? PaymentMethod { get; set; }
    }
}
