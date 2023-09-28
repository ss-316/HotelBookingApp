using Dapper;
using HotelBookingApp.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace HotelBookingApp.Repositories
{
    public class SQLRegistrationRepository:IRegistrationRepository
    {
        private IDbConnection db;
        public SQLRegistrationRepository(IConfiguration configuration) 
        {
            this.db = new SqlConnection(configuration.GetConnectionString("HotelBookingConnectionString"));
        }

        public async Task<RegisteredUsers> Create(RegisteredUsers registeredUsers)
        {
            var sql = "INSERT INTO RegisteredUsers(Email,UserName,Password) VALUES(@Email,@UserName,@Password);"
                 + "SELECT CAST(SCOPE_IDENTITY() AS int);";
            var id = db.Query<int>(sql, registeredUsers).Single();

            registeredUsers.Id = id;
            return registeredUsers;
        }
        public RegisteredUsers GetUserByUsernameAndPassword(string username, string password)
        {
            
            var sql = "SELECT * FROM RegisteredUsers WHERE UserName = @UserName AND Password = @Password";
            return db.QueryFirstOrDefault<RegisteredUsers>(sql, new { Username = username, Password = password });

        }

    }
}
