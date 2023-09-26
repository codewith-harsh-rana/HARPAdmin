using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HARPAdmin.Models
{
    public class User:BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]

        public int UserId { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? UserName { get; set; }

        public string? Password { get; set; }

        public int AccessLevelld { get; set; }
    }
}
