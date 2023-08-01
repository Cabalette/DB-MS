using DB_MS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace DB_MS.Data.Configurations
{
    public class RolePermissionConfiguration : IEntityTypeConfiguration<RolePermission>
    {
        public void Configure(EntityTypeBuilder<RolePermission> builder)
        {
            builder.Property(x => x.id).HasColumnType("INTEGER").IsRequired();
            builder.Property(x => x.role_id).HasColumnType("INTEGER").IsRequired();
            builder.Property(x => x.permission_id).HasColumnType("SMALLINT").IsRequired();

            builder.HasIndex(x => x.id).IsUnique();
            builder.HasIndex(x => new {x.role_id,x.permission_id}).IsUnique();
        }
    }
}
