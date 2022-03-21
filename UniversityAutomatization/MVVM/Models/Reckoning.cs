using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityAutomatization.MVVM.Models
{
    [Table("Reckonings")]
    public class Reckoning
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey(nameof(Student))] public int StudentId { get; set; }
        [ForeignKey(nameof(Teacher))] public int TeacherId { get; set; }
        [ForeignKey(nameof(Lesson))] public int LessonId { get; set; }
        [Required] public string HoursCount { get; set; }
        [Required] public string Result { get; set; }
        
        [InverseProperty("Reckonings")] public Student Student { get; set; } // many - 1
        [InverseProperty("Reckonings")] public Teacher Teacher { get; set; } // many - 1
        [InverseProperty("Reckonings")] public Lesson Lesson { get; set; } // many - 1
    }
}