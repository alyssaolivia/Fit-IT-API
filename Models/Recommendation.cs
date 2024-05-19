using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fit_IT_API.Models
{
    [Table("Recommendations")]
    public class Recommendation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public required int UserId { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required string Image { get; set; }
        public required string Link { get; set; }
        public required DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
