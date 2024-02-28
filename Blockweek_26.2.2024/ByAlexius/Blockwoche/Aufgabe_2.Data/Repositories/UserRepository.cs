using System.Security.Cryptography;
using Aufgabe_2.Data.Database;
using Aufgabe_2.Data.Interface;
using Aufgabe_2.Data.Models;
using Isopoh.Cryptography.Argon2;

namespace Aufgabe_2.Data.Repositories;

public class UserRepository : IUserRepository
{
    private readonly UserContext _context;

    public UserRepository(UserContext context)
    {
        _context = context;
    }

    public List<User> GetAllUsers()
    {
        return _context.users.ToList();
    }

    public User GetUserById(int id)
    {
        return _context.users.FirstOrDefault(u => u.Id == id);
    }

    public User GetUserByName(string username)
    {
        return _context.users.FirstOrDefault(u => u.Username == username);
    }

    public async Task<bool> AuthenticateUser(string username, string password)
    {
        try
        {
            if (!isDataValid(username, password))
                return false;

            User user = GetUserByName(username);

            string salt = user.Salt;

            if (Argon2.Verify(user.Password, password.Trim() + password.Length + salt))
            {
                Console.WriteLine("Valid User");
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return false;
        }
    }
    
    public async Task<bool> AddUser(string username, string password)
    {
        try
        {
            if (!isDataValid(username, password))
                return false;
            
            string salt = Argon2.Hash(getSalt());
            string passwordHash = Argon2.Hash(password.Trim() + password.Length + salt);
            await _context.users.AddAsync(new User { Password = passwordHash, Username = username, Salt = salt});
            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return false;
        }
    }

    private bool isDataValid(string username, string password)
    {
        if (username.Length > 0 && password.Length > 0)
            return true;
        else
            return false;
    }
    
    private string getSalt()
    {
        RandomNumberGenerator rmg = RandomNumberGenerator.Create();

        int max_lengt = 64;
        byte[] salt = new byte[max_lengt];
        
        rmg.GetNonZeroBytes(salt);

        return Convert.ToBase64String(salt);
    }
}