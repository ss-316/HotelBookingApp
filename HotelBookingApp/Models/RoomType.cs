using System.ComponentModel.DataAnnotations;

namespace HotelBookingApp.Models
{
    public class RoomType
    {
        [Key]
        public int RoomId { get; set; }
        public string? TypeOfRoom {  get; set; }   

    }
}
