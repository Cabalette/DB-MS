using DB_MS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace DB_MS.Data.Configurations
{
    public class InviteConfiguration : IEntityTypeConfiguration<Invite>
    {
        public void Configure(EntityTypeBuilder<Invite> builder)
        {
            builder.Property(x => x.id).HasColumnType("INTEGER").IsRequired();
            builder.Property(x => x.email).HasColumnType("VARCHAR(64)").IsRequired();
            builder.Property(x => x.organization_id).HasColumnType("INTEGER").IsRequired();
            builder.Property(x => x.vacancy_id).HasColumnType("INTEGER");
            builder.Property(x => x.project_id).HasColumnType("INTEGER");

            builder.HasIndex(x => x.id).IsUnique();
        }
    }
}
