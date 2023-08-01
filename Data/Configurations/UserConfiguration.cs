using DB_MS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace DB_MS.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.uid).HasColumnType("UUID").IsRequired();
            builder.Property(x => x.email).HasColumnType("VARCHAR(64)").IsRequired();
            builder.Property(x => x.first_name).HasColumnType("VARCHAR(32)").IsRequired();
            builder.Property(x => x.last_name).HasColumnType("VARCHAR(32)").IsRequired();
            builder.Property(x => x.middle_name).HasColumnType("VARCHAR(32)");
            builder.Property(x => x.phone).HasColumnType("VARCHAR(14)");
            builder.Property(x => x.avatar_id).HasColumnType("INTEGER");
            builder.Property(x => x.email_confirmed).HasDefaultValue(false).HasColumnType("BOOLEAN").IsRequired();

            builder.HasKey(x => x.uid);
            builder.HasIndex(x => x.email).IsUnique();
            builder.HasIndex(x => x.phone).IsUnique();
        }
    }
}
