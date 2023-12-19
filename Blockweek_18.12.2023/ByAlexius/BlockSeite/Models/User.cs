using System.ComponentModel.DataAnnotations.Schema;

namespace BlockSeite.Models
{
    [Table(name: "Users")]
    public class User
    {
        public User(String name, String email) {
            this.UserName = name;
            this.email = email;
        }

        public User() { }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(name: "userid")]
        public int UserId { get; set; }

        [Column(name: "username")]
        public string UserName { get; set; }

        [Column(name: "email")]
        public string email { get; set; }
    }
}
