using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice.Data.Entities
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options){ }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Course> Students { get; set; }
        public DbSet<Course> Teachers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("Courses");

                entity.Property(e => e.Name).IsRequired().HasMaxLength(50);
                entity.HasIndex(e => e.Name);

                entity.HasOne(c => c.Teacher);
                entity.HasMany(c => c.Roster).WithMany(s => s.Schedule);

            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Students");

                entity.HasMany(c => c.Schedule);
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.ToTable("Teachers");
                entity.HasMany(c => c.Schedule);

            });

            modelBuilder.Entity<Teacher>().HasData(
                new Teacher { Id = 1, Name = "Mr. Teacher"});

            modelBuilder.Entity<Course>().HasData(
                new Course { Name = "Course 101", Id = 1, TeacherId = 1, });
        }
    }
}
