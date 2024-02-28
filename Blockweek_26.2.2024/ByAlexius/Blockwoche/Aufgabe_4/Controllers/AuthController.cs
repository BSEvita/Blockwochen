using Aufgabe_4.Interface;
using Aufgabe_4.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aufgabe_4.Controllers;

[ApiController]
public class AuthController : ControllerBase
{
    private IUserRepository _userRepository;

    public AuthController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    [HttpGet("/auth/login")]
    public async Task<IActionResult> Login(string username, string password)
    {
        try
        {
            if(await _userRepository.AuthenticateUser(username, password))
                return Ok("Successfully Authenticated!");

            return Unauthorized("Wrong login data!");
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPost("/auth/register")]
    public async Task<IActionResult> Register(string username, string password)
    {
        try
        {
            await _userRepository.AddUser(username, password);

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