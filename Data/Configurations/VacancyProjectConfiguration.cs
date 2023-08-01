using DB_MS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace DB_MS.Data.Configurations
{
    public class VacancyProjectConfiguration : IEntityTypeConfiguration<VacancyProject>
    {
        public void Configure(EntityTypeBuilder<VacancyProject> builder)
        {
            builder.Property(x => x.id).HasColumnType("INTEGER").IsRequired();
            builder.Property(x => x.project_id).HasColumnType("INTEGER").IsRequired();
            builder.Property(x => x.vacancy_id).HasColumnType("INTEGER").IsRequired();

            builder.HasIndex(x => x.id).IsUnique();
        }
    }
}
