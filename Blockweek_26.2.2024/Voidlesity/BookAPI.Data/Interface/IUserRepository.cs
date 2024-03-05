using BookAPI.Data.Models;

namespace BookAPI.Data.Interface;

public interface IUserRepository
{
    List<User?> GetAllUsers();
    User? GetUserById(int id);
    Task<bool> AddUser(string username, string password);
    Task<bool> AuthenticateUser(string username, string password);
    User GetUserByName(string username);
}