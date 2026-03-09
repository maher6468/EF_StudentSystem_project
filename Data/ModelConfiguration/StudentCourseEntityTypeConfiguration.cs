using EFPorject2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFPorject2.Data.ModelConfiguration
{
    internal class StudentCourseEntityTypeConfiguration : IEntityTypeConfiguration<StudentCourse>
    {
        public void Configure(EntityTypeBuilder<StudentCourse> builder)
        {
            builder.HasKey(sc => new { sc.StudentId, sc.CourseId });
            builder.HasOne(sc => sc.Student)
              .WithMany(s => s.StudentCourses)
              .HasForeignKey(sc => sc.StudentId);

            builder.HasOne(sc => sc.Course)
                   .WithMany(c => c.StudentCourses)
                   .HasForeignKey(sc => sc.CourseId);
        }
    }
}
