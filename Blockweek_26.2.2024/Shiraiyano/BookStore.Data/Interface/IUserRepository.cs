using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Data.Models;

namespace BookStore.Data.Interface
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();
        User GetUserById(int id);
        Task<bool> AddUser(string username, string password);
        Task<bool> AuthenticateUser(string username, string password);
        User GetUserByName(string username);
    }
}
