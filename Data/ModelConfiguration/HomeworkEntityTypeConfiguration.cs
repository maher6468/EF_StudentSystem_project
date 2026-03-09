using EFPorject2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFPorject2.Data.ModelConfiguration
{
    internal class HomeworkEntityTypeConfiguration : IEntityTypeConfiguration<Homework>
    {
        public void Configure(EntityTypeBuilder<Homework> builder)
        {
            builder.HasKey(h => h.HomeworkId);

            builder.Property(h => h.Content)
                   .IsRequired()
                   .IsUnicode(false);

            builder.Property(h => h.ContentType)
                   .IsRequired();

            builder.Property(h => h.SubmissionTime)
                   .IsRequired();

            
        }
    }
}
