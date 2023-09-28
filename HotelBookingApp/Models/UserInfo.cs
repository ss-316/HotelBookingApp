namespace HotelBookingApp.Models
{
    public class UserInfo
    {
        public int UsertId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int No_of_guests { get; set; }
        public int No_of_rooms { get; set; }
        public DateOnly Checkin { get; set; }
        public DateOnly Checkout { get; set; }
        public int Number_of_days { get; set; }

    }
}
