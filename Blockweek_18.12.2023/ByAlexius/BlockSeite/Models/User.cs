using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlockSeite.Models
{
    [Table(name: "Users")]
    public class User
    {
        public User(string name, string email, Role? role) {
            this.UserName = name;
            this.Email = email;

            if (role != null)
                this.Role = role;
        }

        public User() { }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(name: "userid")]
        public int UserId { get; set; }

        [Column(name: "username")]
        public string UserName { get; set; }

        [Column(name: "email")]
        public string Email { get; set; }

        [ForeignKey("roleid")]
        public Role Role { get; set; }
    }
}
