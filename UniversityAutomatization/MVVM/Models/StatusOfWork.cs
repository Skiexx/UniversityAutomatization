using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityAutomatization.MVVM.Models
{
    [Table("StatusesOfWork")]
    public class StatusOfWork
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required] public string StatusName { get; set; }
        
        [InverseProperty("StatusOfWork")] public ICollection<Exam> Exams { get; set; } // 1 - many
        [InverseProperty("StatusOfWork")] public ICollection<DiplomaWork> DiplomaWorks { get; set; } // 1 - many
        [InverseProperty("StatusOfWork")] public ICollection<CourseWork> CourseWorks { get; set; } // 1 - many
    }
}