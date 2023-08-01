using DB_MS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace DB_MS.Data.Configurations
{
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.Property(x => x.id).HasColumnType("INTEGER").IsRequired();
            builder.Property(x => x.name).HasColumnType("VARCHAR(64)").IsRequired();
            builder.Property(x => x.avatar_id).HasColumnType("INTEGER");
            builder.Property(x => x.higher_group_id).HasColumnType("INTEGER").IsRequired();
            builder.Property(x => x.main_vacancy_id).HasColumnType("INTEGER");
            builder.Property(x => x.organization_id).HasColumnType("INTEGER");

            builder.HasIndex(x => x.id).IsUnique();
            builder.HasIndex(x => new { x.organization_id, x.name }).IsUnique();
        }
    }
}
