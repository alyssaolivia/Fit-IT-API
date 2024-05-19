using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fit_IT_API.Models
{

    public class Reminder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("UserId")]
        public required int UserId { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required Recurrence Recurrence { get; set; }
        public required DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public VitalType? VitalType { get; set; }
        public Tracker? Tracker { get; set; }
        public required DateTime ReminderTime { get; set; }
        public required string TimeZone { get; set; }
        public required DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public bool IsDisabled { get; set; } = false;
        public bool IsCompleted { get; set; } = false;
    }
}
