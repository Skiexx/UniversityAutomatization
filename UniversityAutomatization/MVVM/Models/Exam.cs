using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityAutomatization.MVVM.Models
{
    [Table("Exams")]
    public class Exam
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey(nameof(Teacher))] public int? TeacherId { get; set; }
        [Required] public int? HoursCount { get; set; }
        [ForeignKey(nameof(Student))] public int? StudentId { get; set; }
        [ForeignKey(nameof(Lesson))] public int? LessonId { get; set; }
        [ForeignKey(nameof(StatusOfWork))] public int? IdResult { get; set; }
        
        [InverseProperty("Exams")] public Teacher Teacher { get; set; } // many - 1
        [InverseProperty("Exams")] public Student Student { get; set; } // many - 1
        [InverseProperty("Exams")] public Lesson Lesson { get; set; } // many - 1
        [InverseProperty("Exams")] public StatusOfWork StatusOfWork { get; set; } // many - 1
    }
}