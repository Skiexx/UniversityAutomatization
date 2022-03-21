using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityAutomatization.MVVM.Models
{
    [Table("CourseWorks")]
    public class CourseWork
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey(nameof(Student))] public int StudentId { get; set; }
        [ForeignKey(nameof(Teacher))] public int TeacherId { get; set; }
        [ForeignKey(nameof(StatusOfWork))] public int StatusId { get; set; }
        [Required] public string Theme { get; set; }
        
        [InverseProperty("CourseWorks")] public Student Student { get; set; } // many - 1
        [InverseProperty("CourseWorks")] public Teacher Teacher { get; set; } // many - 1
        [InverseProperty("CourseWorks")] public StatusOfWork StatusOfWork { get; set; } // many - 1
    }
}