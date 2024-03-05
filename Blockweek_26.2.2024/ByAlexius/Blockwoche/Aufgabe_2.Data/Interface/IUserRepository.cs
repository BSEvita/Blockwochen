using Aufgabe_2.Data.Models;

namespace Aufgabe_2.Data.Interface;

public interface IUserRepository
{
    List<User> GetAllUsers();
    User GetUserById(int id);
    Task<bool> AddUser(string username, string password);
    Task<bool> AuthenticateUser(string username, string password);
    User GetUserByName(string username);
}