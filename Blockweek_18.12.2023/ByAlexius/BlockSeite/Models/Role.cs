using System.ComponentModel.DataAnnotations.Schema;

namespace BlockSeite.Models
{
	[Table(name: "Roles")]
	public class Role
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column(name: "roleid")]
		public int RoleId { get; set; }

		[Column(name: "name")]
		public string RoleName { get; set; }

		[Column(name: "users")]
		public ICollection<User> Users { get; set; } = new List<User>();
	}
}
