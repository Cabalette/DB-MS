using DB_MS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace DB_MS.Data.Configurations
{
    public class PermissionConfiguration : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.Property(x => x.id).HasColumnType("SMALLINT").IsRequired();
            builder.Property(x => x.name).HasColumnType("VARCHAR(32)").IsRequired();
            builder.Property(x => x.description).HasColumnType("TEXT");

            builder.HasIndex(x=>x.id).IsUnique();
            builder.HasIndex(x=>x.name).IsUnique();
        }
    }
}
