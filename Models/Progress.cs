using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fit_IT_API.Models
{
    public enum Tracker
    {
        Steps,
        Calories,
        Sleep,
        Water,
        Distance,
        Weight,
        HeartRate,
        ActiveMinutes
    }

    [Table("Progress")]
    public class Progress
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public required int UserId { get; set; }
        public required Tracker Tracker { get; set; }
        public required int Value { get; set; }
        public required DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
