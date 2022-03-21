using System.Configuration;
using Microsoft.EntityFrameworkCore;
using UniversityAutomatization.MVVM.Models;

namespace UniversityAutomatization.Core
{
    public class Context : DbContext
    {
        public DbSet<CourseWork> CourseWorks { get; set; }
        public DbSet<DiplomaWork> DiplomaWorks { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Reckoning> Reckonings { get; set; }
        public DbSet<StatusOfWork> StatusesOfWork { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public Context()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["Db"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //void
        }
    }
}