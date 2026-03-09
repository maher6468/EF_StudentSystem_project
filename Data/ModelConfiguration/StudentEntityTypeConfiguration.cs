using EFPorject2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFPorject2.Data.ModelConfiguration
{
    internal class StudentEntityTypeConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(nameof(Student.StudentId));
            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(true);

            builder.Property(p => p.PhoneNumber)
               .HasMaxLength(10)
               .IsUnicode(false)
               .IsRequired(false);

            builder.Property(p => p.Birthday)
               .IsRequired(false);
        }
    }
}
