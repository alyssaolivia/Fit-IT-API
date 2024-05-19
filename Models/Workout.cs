using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fit_IT_API.Models
{
    public enum Recurrence
    {
        Daily,
        Weekly,
        Monthly,
        Yearly
    }

    public enum Mood
    {
        Happy,
        Sad,
        Angry,
        Excited,
        Depressed,
        Anxious,
        Stressed,
        Relaxed,
        Tired,
        Energetic
    }

    public enum WorkoutType
    {
        Cardio,
        Strength,
        Flexibility,
        Balance,
        Endurance
    }

    [Table("Workouts")]
    public class Workout
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public Mood? MoodBefore { get; set; }
        public Mood? MoodAfter { get; set; }
        public required int CaloriesBurned { get; set; }
        public required Recurrence Recurrence { get; set; }
        [ForeignKey("UserId")]
        public required int UserId { get; set; }
        public required WorkoutType WorkoutType { get; set; }
        public required DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public bool IsCompleted { get; set; } = false;
    }
}
