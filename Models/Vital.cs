using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fit_IT_API.Models
{
    public enum VitalType
    {
        BloodPressure,
        HeartRate,
        BloodSugar,
        Weight,
        Height,
        Temperature,
        OxygenSaturation,
        RespiratoryRate,
        Cholesterol,
        Stress,
        Pain,
        Menstruation,
        Allergy,
        Symptom,
        Condition,
        BodyTemperature,
        BodyMassIndex,
        BodyFatPercentage,
        LeanBodyMass
    }

    [Table("Vitals")]
    public class Vital
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("UserId")]
        public required int UserId { get; set; }
        public required VitalType Type { get; set; }
        public required string Value { get; set; }
        public required DateTime Date { get; set; } = DateTime.Now;

    }
}
