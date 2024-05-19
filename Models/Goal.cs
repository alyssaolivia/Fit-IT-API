using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Fit_IT_API.Models
{
    public enum GoalType
    {
        WeightLoss,
        WeightGain,
        MaintainWeight,
        Fitness,
        Health,
        Other
    }

    [Table("Goals")]
    public class Goal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        [ForeignKey("UserId")]
        public required int UserId { get; set; }
        public required GoalType GoalType { get; set; }
        public required DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; }
        public required DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public bool IsCompleted { get; set; } = false;
    }
}
