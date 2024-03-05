using System.Security.Cryptography;
using BookAPI.Data.Database;
using BookAPI.Data.Interface;
using BookAPI.Data.Models;
using Isopoh.Cryptography.Argon2;

namespace BookAPI.Data.Repositories;

public class UserRepository : IUserRepository
{
    private readonly UserContext _context;

    public UserRepository(UserContext context)
    {
        _context = context;
    }

    public List<User?> GetAllUsers()
    {
        return _context.users.ToList();
    }

    public User? GetUserById(int id)
    {
        return _context.users.FirstOrDefault(u => u.Id == id);
    }

    public User GetUserByName(string username)
    {
        return _context.users.FirstOrDefault(u => u.Username == username);
    }

    public Task<bool> AuthenticateUser(string username, string password)
    {
        try
        {
            if (!isDataValid(username, password))
                return Task.FromResult(false);

            User user = GetUserByName(username);

            string salt = user.Salt;

            if (Argon2.Verify(user.Password, password.Trim() + password.Length + salt))
            {
                Console.WriteLine("Valid User");
                return Task.FromResult(true);
            }

            return Task.FromResult(false);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return Task.FromResult(false);
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

        int maxLength = 64;
        byte[] salt = new byte[maxLength];
        
        rmg.GetNonZeroBytes(salt);

        return Convert.ToBase64String(salt);
    }
}