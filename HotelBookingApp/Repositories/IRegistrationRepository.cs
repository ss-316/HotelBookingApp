using HotelBookingApp.Models;

namespace HotelBookingApp.Repositories
{
    public interface IRegistrationRepository
    {
        Task<RegisteredUsers> Create(RegisteredUsers registeredUsers);
        public RegisteredUsers GetUserByUsernameAndPassword(string username, string password);
    }
}
