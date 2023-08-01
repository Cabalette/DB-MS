using DB_MS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace DB_MS.Data.Configurations
{
    public class PasswordConfiguration : IEntityTypeConfiguration<Password>
    {
        public void Configure(EntityTypeBuilder<Password> builder)
        {
            builder.Property(x => x.user_uid).HasColumnType("UUID").IsRequired();
            builder.Property(x => x.hash).HasColumnType("TEXT").IsRequired();
            builder.Property(x => x.salt).HasColumnType("TEXT").IsRequired();

            builder.HasKey(x=>x.user_uid);
        }
    }
}
