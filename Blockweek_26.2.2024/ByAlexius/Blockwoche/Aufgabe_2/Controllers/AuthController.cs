using Aufgabe_2.Data.Interface;
using Aufgabe_2.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aufgabe_2.Controllers;

[ApiController]
public class AuthController : ControllerBase
{
    private IUserRepository _userRepository;

    public AuthController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    [HttpPost("/auth/login")]
    public async Task<IActionResult> Login([FromBody] Credentials credentials)
    {
        try
        {
            if(await _userRepository.AuthenticateUser(credentials.Username, credentials.Password))
                return Ok("Successfully Authenticated!");

            return Unauthorized("Wrong login data!");
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPost("/auth/register")]
    public async Task<IActionResult> Register([FromBody] Credentials credentials)
    {
        try
        {
            await _userRepository.AddUser(credentials.Username, credentials.Password);

            return Ok("User registered successfully!");
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet("auth/getUsers")]
    public IEnumerable<User> GetAllUsers()
    {
        return _userRepository.GetAllUsers();
    }
}

public class Credentials
{
    public string Username { get; set; }
    public string Password { get; set; }
}