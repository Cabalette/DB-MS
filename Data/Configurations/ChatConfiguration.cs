using DB_MS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace DB_MS.Data.Configurations
{
    public class ChatConfiguration : IEntityTypeConfiguration<Chat>
    {
        public void Configure(EntityTypeBuilder<Chat> builder)
        {
            builder.Property(x => x.id).HasColumnType("INTEGER").IsRequired();
            builder.Property(x => x.title).HasColumnType("VARCHAR(64)").IsRequired();
            builder.Property(x => x.organization_id).HasColumnType("INTEGER").IsRequired();
            builder.Property(x => x.avatar_id).HasColumnType("INTEGER");

            builder.HasIndex(x => x.id).IsUnique();
        }
    }
}
