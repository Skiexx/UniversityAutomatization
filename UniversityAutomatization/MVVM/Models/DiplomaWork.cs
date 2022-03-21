using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityAutomatization.MVVM.Models
{
    [Table("DiplomaWorks")]
    public class DiplomaWork
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey(nameof(Student))] public int StudentId { get; set; }
        [ForeignKey(nameof(Teacher))] public int TeacherId { get; set; }
        [ForeignKey(nameof(StatusOfWork))] public int IdResult { get; set; }
        [Required] public string Theme { get; set; }
        
        [InverseProperty("DiplomaWorks")] public StatusOfWork StatusOfWork { get; set; } // many - 1
        [InverseProperty("DiplomaWorks")] public Teacher Teacher { get; set; } // many - 1
        [InverseProperty("DiplomaWork")] public Student Student { get; set; } // 1 - 1
    }
}