using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityAutomatization.MVVM.Models
{
    [Table("Lessons")]
    public class Lesson
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required] public string? LessonName { get; set; }
        [Required] public int? HoursCount { get; set; }
        [ForeignKey(nameof(Teacher))] public int? TeacherId { get; set; }
        
        [InverseProperty("Lessons")] public Teacher Teacher { get; set; } // many - 1
        [InverseProperty("Lesson")] public ICollection<Exam> Exams { get; set; } // 1 - many
        [InverseProperty("Lesson")] public ICollection<Reckoning> Reckonings { get; set; } // 1 - many
    }
}