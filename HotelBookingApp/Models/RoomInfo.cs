using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBookingApp.Models
{
    public class RoomInfo
    {
        [Key]
        public int RoomNumber { get; set; }
        public int IsBooked { get; set; }

        [ForeignKey("RoomId")]
        public RoomType RoomType { get; set; }
    }
}
