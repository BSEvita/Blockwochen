using System.ComponentModel.DataAnnotations.Schema;

namespace BlockSeite.Models
{
	[Table(name: "Roles")]
	public class Role
	{
		public Role() { }

		public Role(int id, String RoleName)
		{
			this.RoleId = id;
			this.RoleName = RoleName;
		}

		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column(name: "roleid")]
		public int RoleId { get; set; }

		[Column(name: "name")]
		public string RoleName { get; set; }

		[Column(name: "admin")]
		public bool isAdmin { get; set; }

		[Column(name: "users")]
		public ICollection<User> Users { get; set; } = new List<User>();
	}
}
