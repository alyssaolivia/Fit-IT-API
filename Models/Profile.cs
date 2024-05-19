using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Fit_IT_API.Models
{
    [Table("Profiles")]
    public class Profile
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("UserId")]
        public required int UserId { get; set; }

        //Public 
        public required string Name { get; set; }
        public required string City { get; set; }
        public required string Country { get; set; }
        public required string Bio { get; set; }
        public required string ProfileImage { get; set; }
        public required string CoverImage { get; set; }
        public required string Website { get; set; }
        [DataType(DataType.Date)]
        public required string MemberSince { get; set; }
        public required KeyValuePair<int, string>[] Socials { get; set; }

        //User-determined privacy
        [DataType(DataType.PhoneNumber)]
        public required string Phone { get; set; }
        [DataType(DataType.EmailAddress)]
        public required string Email { get; set; }
        public required string TimeZone { get; set; }
        public string[]? Languages { get; set; }

        //Member-Only
        public Goal[]? Goals { get; set; }
        public Reminder[]? Reminders { get; set; }
        public Recommendation[]? Recommendations { get; set; }
        public Progress[]? Progress { get; set; }
        public Workout[]? Workouts { get; set; }
        public string[]? Interests { get; set; }

    }
}
