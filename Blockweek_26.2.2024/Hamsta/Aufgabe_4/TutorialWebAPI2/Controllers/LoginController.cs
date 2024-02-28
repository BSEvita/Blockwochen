using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TutorialWebAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private static Dictionary<string, string> userCredentials = new Dictionary<string, string>();

        [HttpPost("register")]
        public IActionResult Register([FromBody] UserCredentials credentials)
        {
            if (userCredentials.ContainsKey(credentials.Username))
            {
                return Conflict("Username already exists");
            }

            userCredentials.Add(credentials.Username, credentials.Password);

            return Ok("User registered successfully");
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] UserCredentials credentials)
        {
            if (!userCredentials.ContainsKey(credentials.Username))
            {
                return NotFound("User not found");
            }

            string storedPassword = userCredentials[credentials.Username];

            if (credentials.Password != storedPassword)
            {
                return Unauthorized("Invalid password");
            }

            return Ok("Login successful");
        }
    }

    public class UserCredentials
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}