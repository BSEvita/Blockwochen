using System.ComponentModel.DataAnnotations.Schema;

namespace Aufgabe_4.Models;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Salt { get; set; }
}