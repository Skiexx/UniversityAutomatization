using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityAutomatization.MVVM.Models
{
    [Table("Teachers")]
    public class Teacher
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required] public string FirstName { get; set; }
        [Required] public string LastName { get; set; }
        [Required] public string MiddleName { get; set; }
        [Required, Column(TypeName = "DATA")] public DateTime DateOfBirth { get; set; }
        [Required] public int CabinetNumber { get; set; }
        [NotMapped] public string FullName => $"{LastName} {FirstName} {MiddleName}";
        
        [InverseProperty("Teacher")] public ICollection<Lesson> Lessons { get; set; } // 1 - many
        [InverseProperty("Teacher")] public ICollection<Exam> Exams { get; set; } // 1 - many
        [InverseProperty("Teacher")] public ICollection<DiplomaWork> DiplomaWorks { get; set; } // 1 - many
        [InverseProperty("Teacher")] public ICollection<Reckoning> Reckonings { get; set; } // 1 - many
        [InverseProperty("Teacher")] public ICollection<CourseWork> CourseWorks { get; set; } // 1 - many
    }
}