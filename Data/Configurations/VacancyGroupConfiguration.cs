using DB_MS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace DB_MS.Data.Configurations
{
    public class VacancyGroupConfiguration : IEntityTypeConfiguration<VacancyGroup>
    {
        public void Configure(EntityTypeBuilder<VacancyGroup> builder)
        {
            builder.Property(x => x.id).HasColumnType("INTEGER").IsRequired();
            builder.Property(x => x.vacancy_id).HasColumnType("INTEGER").IsRequired();
            builder.Property(x => x.group_id).HasColumnType("INTEGER").IsRequired();

            builder.HasIndex(x => x.id).IsUnique();
            builder.HasIndex(x => new { x.vacancy_id, x.group_id }).IsUnique();
        }
    }
}
