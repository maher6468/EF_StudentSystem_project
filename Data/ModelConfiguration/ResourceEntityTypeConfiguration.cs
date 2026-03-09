using EFPorject2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFPorject2.Data.ModelConfiguration
{
    internal class ResourceEntityTypeConfiguration : IEntityTypeConfiguration<Resource>
    {
        public void Configure(EntityTypeBuilder<Resource> builder)
        {
            builder.HasKey(r => r.ResourceId);

            builder.Property(r => r.Name)
                   .IsRequired()
                   .HasMaxLength(50)
                   .IsUnicode(true);
            builder.Property(r => r.Url)
               .IsRequired()
               .IsUnicode(false);

            builder.Property(r => r.ResourceType)
                   .IsRequired();

            builder.HasOne(r => r.Course)
                   .WithMany(c => c.Resources)
                   .HasForeignKey(r => r.CourseId);
        }
    }
}
