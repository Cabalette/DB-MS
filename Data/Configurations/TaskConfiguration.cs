using DB_MS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace DB_MS.Data.Configurations
{
    public class TaskConfiguration : IEntityTypeConfiguration<DB_MS.Models.Task>
    {
        public void Configure(EntityTypeBuilder<DB_MS.Models.Task> builder)
        {
            builder.Property(x => x.id).HasColumnType("INTEGER").IsRequired();
            builder.Property(x => x.title).HasColumnType("VARCHAR(64)").IsRequired();
            builder.Property(x => x.description).HasColumnType("VARCHAR(64)");
            builder.Property(x => x.assigned_to_vacancy_id).HasColumnType("INTEGER");
            builder.Property(x => x.assigned_by_vacancy_id).HasColumnType("INTEGER").IsRequired();
            builder.Property(x => x.status_id).HasColumnType("SMALLINT").IsRequired();
            builder.Property(x => x.higher_task_id).HasColumnType("INTEGER");
            builder.Property(x => x.from_date).HasColumnType("TIMESTAMP");
            builder.Property(x => x.to_date).HasColumnType("TIMESTAMP");
            builder.Property(x => x.is_blocking).HasColumnType("BOOLEAN").HasDefaultValue(false).IsRequired();
            builder.Property(x => x.is_delegated).HasColumnType("BOOLEAN").HasDefaultValue(false).IsRequired();

            builder.HasIndex(x => x.id).IsUnique();
        }
    }
}
