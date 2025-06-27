using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL_LIB.HotelModels
{
    public class Room
    {
        public int RoomId { get; set; }

        public string RoomNumber { get; set; } = null!;

        public string? RoomType { get; set; }

        public int? BedCount { get; set; }

        public decimal? PricePerNight { get; set; }

        public bool? IsAvailable { get; set; }
    }
}
