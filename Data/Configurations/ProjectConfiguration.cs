using DB_MS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace DB_MS.Data.Configurations
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.Property(x => x.id).HasColumnType("INTEGER").IsRequired();
            builder.Property(x => x.name).HasColumnType("VARCHAR(64)").IsRequired();
            builder.Property(x => x.avatar_id).HasColumnType("INTEGER");
            builder.Property(x => x.organization_id).HasColumnType("INTEGER").IsRequired();
            builder.Property(x => x.main_user_uid).HasColumnType("UUID");

            builder.HasKey(x => x.id);
            builder.HasIndex(x => x.id).IsUnique();
            builder.HasIndex(x => new { x.organization_id, x.name }).IsUnique();

        }
    }
}
