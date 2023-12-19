using System.ComponentModel.DataAnnotations.Schema;

namespace BlockSeite.Data
{
    [Table(name: "Users")]
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(name: "userid")]
        public int UserId { get; set; }

        [Column(name: "username")]
        public string UserName { get; set; }

        [Column(name: "email")]
        public string email { get; set; }
    }
}
