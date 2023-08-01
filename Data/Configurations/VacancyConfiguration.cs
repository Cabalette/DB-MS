using DB_MS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace DB_MS.Data.Configurations
{
    public class VacancyConfiguration : IEntityTypeConfiguration<Vacancy>
    {
        public void Configure(EntityTypeBuilder<Vacancy> builder)
        {
            builder.Property(x => x.id).HasColumnType("INTEGER").IsRequired();
            builder.Property(x => x.name).HasColumnType("VARCHAR(64)").IsRequired();
            builder.Property(x => x.email).HasColumnType("VARCHAR(64)").IsRequired();
            builder.Property(x => x.phone).HasColumnType("VARCHAR(14)").IsRequired();
            builder.Property(x => x.role_id).HasColumnType("INTEGER").IsRequired();
            builder.Property(x => x.user_uid).HasColumnType("VARCHAR");
            builder.Property(x => x.confirmed).HasColumnType("BOOLEAN").HasDefaultValue(false).IsRequired();

            builder.HasIndex(x => x.id).IsUnique();
            builder.HasIndex(x => new { x.name, x.role_id }).IsUnique();
            builder.HasIndex(x => x.email).IsUnique();
            builder.HasIndex(x => x.phone).IsUnique();
        }
    }
}
