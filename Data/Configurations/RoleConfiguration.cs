using DB_MS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace DB_MS.Data.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.Property(x => x.id).HasColumnType("INTEGER").IsRequired();
            builder.Property(x => x.name).HasColumnType("VARCHAR(64)").IsRequired();
            builder.Property(x => x.higher_role_id).HasColumnType("INTEGER");
            builder.Property(x => x.organization_id).HasColumnType("INTEGER").IsRequired();

            builder.HasIndex(x => x.id).IsUnique();
            builder.HasIndex(x => new {x.id,x.name}).IsUnique();
        }
    }
}
