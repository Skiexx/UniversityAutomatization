using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityAutomatization.MVVM.Models
{
    [Table("Students")]
    public class Student
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required] public string FirstName { get; set; }
        [Required] public string LastName { get; set; }
        [Required] public string MiddleName { get; set; }
        [Required, Column(TypeName = "DATA")] public DateTime DateOfBirth { get; set; }
        [Required] public int GroupNumber { get; set; }
        [Required] public string PhoneNumber { get; set; }
        [NotMapped] public string FullName => $"{LastName} {FirstName} {MiddleName}";
        
        [InverseProperty("Student")] public ICollection<Exam> Exams { get; set; } // 1 - many
        [InverseProperty("Student")] public DiplomaWork DiplomaWork { get; set; } // 1 - 1
        [InverseProperty("Student")] public ICollection<Reckoning> Reckonings { get; set; } // 1 - many
        [InverseProperty("Student")] public ICollection<CourseWork> CourseWorks { get; set; } // 1 - many
    }
}