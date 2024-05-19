using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fit_IT_API.Models
{
    public enum Role
    {
        Admin,
        User
    }

    [Table("Users")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
        public required string Email { get; set; }
        public Role? UserRole { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [ForeignKey("UserAuthId")]
        public int? UserAuthId { get; set; }
        public bool IsVerified { get; set; } = false;
        public bool IsLocked { get; set; } = false;
        public bool IsDisabled { get; set; } = false;
        public bool IsDeleted { get; set; } = false;
        public int FailedLoginAttempts { get; set; } = 0;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
