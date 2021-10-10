using Assignment.Models;

namespace Assignment.Data
{
    public interface IUsersService
    {
        Users ValidateUsers(string userName, string Password);
    }
}