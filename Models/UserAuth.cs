using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;

namespace Fit_IT_API.Models
{
    [Table("UserAuth")]
    public class UserAuth
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Salt { get; set; } = RandomNumberGenerator.GetInt32(100000, 999999);
        public required int UserId { get; set; }
        public required string Token { get; set; }
        public required string RefreshToken { get; set; }
        public required DateTime TokenExpires { get; set; }
        public required DateTime RefreshTokenExpires { get; set; }
    }
}
