using System.ComponentModel.DataAnnotations;

namespace BlockSeite.Models
{
	public class UserForm
	{
		public string UserName { get; set; }

		[Required(ErrorMessage = "The email address is required")]
		[EmailAddress(ErrorMessage = "Invalid Email Address")]
		public string Email { get; set; }

		public int Role { get; set; }
	}
}
