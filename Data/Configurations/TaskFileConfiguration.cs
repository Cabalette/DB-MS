using DB_MS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace DB_MS.Data.Configurations
{
    public class TaskFileConfiguration : IEntityTypeConfiguration<TaskFile>
    {
        public void Configure(EntityTypeBuilder<TaskFile> builder)
        {
            builder.Property(x => x.id).HasColumnType("INTEGER").IsRequired();
            builder.Property(x => x.task_id).HasColumnType("INTEGER").IsRequired();
            builder.Property(x => x.attachment_id).HasColumnType("INTEGER").IsRequired();

            builder.HasIndex(x => x.id).IsUnique();
            builder.HasIndex(x => new {x.task_id,x.attachment_id}).IsUnique();
        }
    }
}
