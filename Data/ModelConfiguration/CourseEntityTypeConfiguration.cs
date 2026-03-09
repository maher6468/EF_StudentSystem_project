using EFPorject2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFPorject2.Data.ModelConfiguration
{
    internal class CourseEntityTypeConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(c => c.CourseId);

            builder.Property(c => c.Name)
                   .IsRequired()
                   .HasMaxLength(80)
                   .IsUnicode(true);

            builder.Property(c => c.Description)
                   .IsRequired(false)
                   .IsUnicode(true);

            builder.Property(c => c.StartDate)
                   .IsRequired();

            builder.Property(c => c.EndDate)
                   .IsRequired();

            builder.Property(c => c.Price)
                   .IsRequired()
                   .HasColumnType("decimal(18,2)");
        }
    }
}
